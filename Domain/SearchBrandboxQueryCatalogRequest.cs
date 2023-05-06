using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// SearchBrandboxQueryCatalogRequest Data Structure.
    /// </summary>
    [Serializable]
    public class SearchBrandboxQueryCatalogRequest : AopObject
    {
        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }
    }
}
