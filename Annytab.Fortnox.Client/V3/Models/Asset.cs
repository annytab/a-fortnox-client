using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for assets
    /// </summary>
    public class AssetsRoot
    {
        #region Variables

        public IList<Asset> Assets { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public AssetsRoot()
        {
            this.Assets = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for an asset
    /// </summary>
    public class AssetRoot
    {
        #region Variables

        public Asset Asset { get; set; }
        public Asset Assets { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public AssetRoot()
        {
            this.Asset = null;
            this.Assets = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents an asset
    /// </summary>
    public class Asset
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public string Id { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string StatusId { get; set; }
        public string CostCenter { get; set; }
        public string Project { get; set; }
        public string Type { get; set; }
        public string TypeId { get; set; }
        public string DepreciationMethod { get; set; }
        public decimal? AcquisitionValue { get; set; }
        public decimal? DepreciateToResidualValue { get; set; }
        public string AcquisitionDate { get; set; }
        public string AcquisitionStart { get; set; }
        public string DepreciationFinal { get; set; }
        public string DepreciatedTo { get; set; }
        public decimal? ManualOb { get; set; }
        public string Notes { get; set; }
        public string Reference { get; set; }
        public string Brand { get; set; }
        public string InsuredNumber { get; set; }
        public string InsuredWith { get; set; }
        public string Group { get; set; }
        public string Room { get; set; }
        public string Placement { get; set; }
        public string Department { get; set; }
        public IList<AssetHistoryRow> History { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public Asset()
        {
            // Set values for instance variables
            this.Url = null;
            this.Id = null;
            this.Number = null;
            this.Description = null;
            this.Status = null;
            this.StatusId = null;
            this.CostCenter = null;
            this.Project = null;
            this.Type = null;
            this.TypeId = null;
            this.DepreciationMethod = null;
            this.AcquisitionValue = null;
            this.DepreciateToResidualValue = null;
            this.AcquisitionDate = null;
            this.AcquisitionStart = null;
            this.DepreciationFinal = null;
            this.DepreciatedTo = null;
            this.ManualOb = null;
            this.Notes = null;
            this.Reference = null;
            this.Brand = null;
            this.InsuredNumber = null;
            this.InsuredWith = null;
            this.Group = null;
            this.Room = null;
            this.Placement = null;
            this.Department = null;
            this.History = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for assets deprication
    /// </summary>
    public class AssetsDepreciationRoot
    {
        #region Variables

        public IList<AssetDepreciation> Assets { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public AssetsDepreciationRoot()
        {
            this.Assets = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represent an asset deprication
    /// </summary>
    public class AssetDepreciation
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public string Id { get; set; }
        public decimal? AccountedValue { get; set; }
        public decimal? DepreciationAmount { get; set; }
        public string DepreciationPeriod { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public AssetDepreciation()
        {
            // Set values for instance variables
            this.Url = null;
            this.Id = null;
            this.AccountedValue = null;
            this.DepreciationAmount = null;
            this.DepreciationPeriod = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace