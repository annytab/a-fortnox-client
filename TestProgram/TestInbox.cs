using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;
using System.IO;

namespace TestProgram
{
    [TestClass]
    public class TestInbox
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestInbox()
        {
            this.config = new Config();

        } // End of the constructor

        #endregion

        #region Methods

        /// <summary>
        /// Test to add a post
        /// </summary>
        [TestMethod]
        public async Task TestUploadFile()
        {
            // Set the file path  
            string path = "D:\\Bilder\\1960.jpg";

            using (FileStream stream = System.IO.File.OpenRead(path))
            {
                FileRoot post = await config.fortnox_repository.UploadFile<FileRoot>(config.client, stream, "bil-test2.jpg", "inbox?path=inbox_v");
            }

        } // End of the TestUploadFile method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            FolderRoot post = await config.fortnox_repository.Get<FolderRoot>(config.client, "inbox/inbox_v");

            // Test evaluation
            Assert.AreNotEqual(0, post.Folder.Files.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a folder
            FolderRoot post = await config.fortnox_repository.Get<FolderRoot>(config.client, "inbox/inbox_v");

            // Test evaluation
            Assert.AreNotEqual(null, post.Folder);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to download a file
        /// </summary>
        [TestMethod]
        public async Task TestDownloadFile()
        {
            // Create a file stream
            using (FileStream fileStream = System.IO.File.OpenWrite("D:\\Bilder\\inbox.jpg"))
            {
                // Get the file
                await config.fortnox_repository.DownloadFile(config.client, fileStream, "inbox/54ac7b74-9fff-4e29-84ed-80556b961cde");
            }

        } // End of the TestDownloadFile method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Delete a folder or a file (inbox?path=inbox_v) 
            bool success = await config.fortnox_repository.Delete(config.client, "inbox/54ac7b74-9fff-4e29-84ed-80556b961cde");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace