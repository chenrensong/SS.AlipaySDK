using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayUserAgreementUserverifyApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAgreementUserverifyApplyModel : AopObject
    {
        /// <summary>
        /// 协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }
    }
}
