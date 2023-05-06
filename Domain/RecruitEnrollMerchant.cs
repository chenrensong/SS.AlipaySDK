using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// RecruitEnrollMerchant Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitEnrollMerchant : AopObject
    {
        /// <summary>
        /// 商户唯一ID(商户pid)
        /// </summary>
        [XmlElement("merchant_uid")]
        public string MerchantUid { get; set; }
    }
}
