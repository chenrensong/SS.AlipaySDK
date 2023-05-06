using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AntMerchantExpandInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandInfoQueryModel : AopObject
    {
        /// <summary>
        /// 商户号，目前是商户pid
        /// </summary>
        [XmlElement("merchant_no")]
        public string MerchantNo { get; set; }
    }
}
