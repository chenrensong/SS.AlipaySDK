using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcBlacklistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcBlacklistQueryModel : AopObject
    {
        /// <summary>
        /// ETC平台协议号
        /// </summary>
        [XmlElement("biz_agreement_no")]
        public string BizAgreementNo { get; set; }
    }
}
