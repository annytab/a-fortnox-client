using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;
using System.IO;

namespace TestProgram
{
    [TestClass]
    public class TestArchive
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestArchive()
        {
            this.config = new Config();

        } // End of the constructor

        #endregion

        #region Methods

        /// <summary>
        /// Test to add a post
        /// </summary>
        [TestMethod]
        public async Task TestAddPost()
        {
            // Create a post
            FolderRoot post = new FolderRoot
            {
                Folder = new Folder
                {
                   Name = "sub-hej"
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<FolderRoot>(config.client, post, "archive/?path=test\\sub\\sub-folder");

        } // End of the TestAddPost method

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
                FileRoot post = await config.fortnox_repository.UploadFile<FileRoot>(config.client, stream, "bil-test.jpg", "archive?path=test\\sub");
            }

        } // End of the TestUploadFile method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            FolderRoot post = await config.fortnox_repository.Get<FolderRoot>(config.client, "archive?path=test\\sub");

            // Test evaluation
            Assert.AreNotEqual(0, post.Folder.Folders.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a folder
            FolderRoot post = await config.fortnox_repository.Get<FolderRoot>(config.client, "archive?path=test\\sub");

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
            using (FileStream fileStream = System.IO.File.OpenWrite("D:\\Bilder\\fortnox.jpg"))
            {
                // Get the file
                await config.fortnox_repository.DownloadFile(config.client, fileStream, "archive/787ea184-ffda-491e-ac83-4d79397aa0a7");
            }

        } // End of the TestDownloadFile method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Delete a folder or a file (archive?path=test\\sub) 
            bool success = await config.fortnox_repository.Delete(config.client, "archive/787ea184-ffda-491e-ac83-4d79397aa0a7");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace