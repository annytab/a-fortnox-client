using System.Collections.Generic;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for trusted domains
    /// </summary>
    public class TrustedDomainsRoot
    {
        #region Variables

        public IList<TrustedDomain> TrustedDomains { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public TrustedDomainsRoot()
        {
            this.TrustedDomains = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for trusted domain
    /// </summary>
    public class TrustedDomainRoot
    {
        #region Variables

        public TrustedDomain TrustedDomain { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public TrustedDomainRoot()
        {
            this.TrustedDomain = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a trusted domain
    /// </summary>
    public class TrustedDomain
    {
        #region Variables

        public string Id { get; set; }
        public string Domain { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public TrustedDomain()
        {
            // Set values for instance variables
            this.Id = null;
            this.Domain = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace