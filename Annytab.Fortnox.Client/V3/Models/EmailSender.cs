using System.Collections.Generic;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for email senders
    /// </summary>
    public class EmailSendersRoot
    {
        #region Variables

        public EmailSenders EmailSenders { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public EmailSendersRoot()
        {
            this.EmailSenders = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for email senders
    /// </summary>
    public class EmailSenders
    {
        #region Variables

        public IList<EmailSender> TrustedSenders { get; set; }
        public IList<EmailSender> RejectedSenders { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public EmailSenders()
        {
            this.TrustedSenders = null;
            this.RejectedSenders = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for trusted sender
    /// </summary>
    public class TrustedSenderRoot
    {
        #region Variables

        public EmailSender TrustedSender { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public TrustedSenderRoot()
        {
            this.TrustedSender = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents an email sender
    /// </summary>
    public class EmailSender
    {
        #region Variables

        public string Id { get; set; }
        public string Email { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public EmailSender()
        {
            // Set values for instance variables
            this.Id = null;
            this.Email = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace