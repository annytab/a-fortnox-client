using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for articles
    /// </summary>
    public class ArticlesRoot
    {
        #region Variables

        public IList<Article> Articles { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public ArticlesRoot()
        {
            this.Articles = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for article
    /// </summary>
    public class ArticleRoot
    {
        #region Variables

        public Article Article { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public ArticleRoot()
        {
            this.Article = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents an article
    /// </summary>
    public class Article
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public string ArticleNumber { get; set; }
        public bool? Bulky { get; set; }
        public string ConstructionAccount { get; set; }
        public Int32? Depth { get; set; }
        public string Description { get; set; }
        public decimal? DisposableQuantity { get; set; }
        public string EAN { get; set; }
        public string EUAccount { get; set; }
        public string EUVATAccount { get; set; }
        public string ExportAccount { get; set; }
        public Int32? Height { get; set; }
        public bool? Housework { get; set; }
        public string HouseworkType { get; set; }
        public bool? Active { get; set; }
        public string Manufacturer { get; set; }
        public string ManufacturerArticleNumber { get; set; }
        public string Note { get; set; }
        public string PurchaseAccount { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? QuantityInStock { get; set; }
        public decimal? ReservedQuantity { get; set; }
        public string SalesAccount { get; set; }
        public bool? StockGoods { get; set; }
        public string StockPlace { get; set; }
        public decimal? StockValue { get; set; }
        public decimal? StockWarning { get; set; }
        public string SupplierName { get; set; }
        public string SupplierNumber { get; set; }
        public string Type { get; set; }
        public string Unit { get; set; }
        public decimal? VAT { get; set; }
        public bool? WebshopArticle { get; set; }
        public Int32? Weight { get; set; }
        public Int32? Width { get; set; }
        public bool? Expired { get; set; }
        public decimal? SalesPrice { get; set; }
        public string CostCalculationMethod { get; set; }
        public string StockAccount { get; set; }
        public string StockChangeAccount { get; set; }
        public decimal? DirectCost { get; set; }
        public decimal? FreightCost { get; set; }
        public decimal? OtherCost { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public Article()
        {
            this.Url = null;
            this.Active = null;
            this.ArticleNumber = null;
            this.Bulky = null;
            this.ConstructionAccount = null;
            this.Depth = null;
            this.Description = null;
            this.DisposableQuantity = null;
            this.EAN = null;
            this.EUAccount = null;
            this.EUVATAccount = null;
            this.ExportAccount = null;
            this.Height = null;
            this.Housework = null;
            this.HouseworkType = null;
            this.Manufacturer = null;
            this.ManufacturerArticleNumber = null;
            this.Note = null;
            this.PurchaseAccount = null;
            this.PurchasePrice = null;
            this.QuantityInStock = null;
            this.ReservedQuantity = null;
            this.SalesAccount = null;
            this.SalesPrice = null;
            this.StockGoods = null;
            this.StockPlace = null;
            this.StockValue = null;
            this.StockWarning = null;
            this.SupplierName = null;
            this.SupplierNumber = null;
            this.Type = null;
            this.Unit = null;
            this.VAT = null;
            this.WebshopArticle = null;
            this.Weight = null;
            this.Width = null;
            this.Expired = null;
            this.CostCalculationMethod = null;
            this.StockAccount = null;
            this.StockChangeAccount = null;
            this.DirectCost = null;
            this.FreightCost = null;
            this.OtherCost = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace