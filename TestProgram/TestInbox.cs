using System.IO;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using Annytab.Fortnox.Client.V3;

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
                FortnoxResponse<FileRoot> fr = await config.fortnox_client.UploadFile<FileRoot>(stream, "bil-test2.jpg", "inbox?path=inbox_v");

                // Log the error
                if (fr.model == null)
                {
                    config.logger.LogError(fr.error);
                }

                // Test evaluation
                Assert.AreNotEqual(null, fr.model);
            }

        } // End of the TestUploadFile method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            FortnoxResponse<FolderRoot> fr = await config.fortnox_client.Get<FolderRoot>("inbox/inbox_v");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestGetList method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a folder
            FortnoxResponse<FolderRoot> fr = await config.fortnox_client.Get<FolderRoot>("inbox/inbox_v");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

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
                FortnoxResponse<bool> fr = await config.fortnox_client.DownloadFile(fileStream, "inbox/6d51c5f9-3a53-4f34-91b8-79195e77d83d");

                // Log the error
                if (fr.model == false)
                {
                    config.logger.LogError(fr.error);
                }

                // Test evaluation
                Assert.AreEqual(true, fr.model);
            }

        } // End of the TestDownloadFile method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Delete a folder or a file (inbox?path=inbox_v) 
            FortnoxResponse<bool> fr = await config.fortnox_client.Delete("inbox/6d51c5f9-3a53-4f34-91b8-79195e77d83d");

            // Log the error
            if (fr.model == false)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreEqual(true, fr.model);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace