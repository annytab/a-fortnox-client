using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This class represent a response model and other properties
    /// </summary>
    public class FortnoxResponse<R>
    {
        #region Variables

        public R model { get; set; }
        public string error { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public FortnoxResponse()
        {
            // Set values for instance variables
            this.model = default(R);
            this.error = null;

        } // End of the constructor

        #endregion

        #region Get methods

        /// <summary>
        /// Convert the object to a json string
        /// </summary>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);

        } // End of the ToString method

        #endregion

    } // End of the class

} // End of the namespace