using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandFrontcategorySecurityCreateResponse.
    /// </summary>
    public class AntMerchantExpandFrontcategorySecurityCreateResponse : AopResponse
    {
        /// <summary>
        /// 前台类目ID
        /// </summary>
        [XmlElement("front_category_id")]
        public string FrontCategoryId { get; set; }
    }
}
