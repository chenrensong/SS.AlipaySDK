using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskRecruitenrolledinfoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskRecruitenrolledinfoBatchqueryModel : AopObject
    {
        /// <summary>
        /// 零售商的pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }
    }
}
