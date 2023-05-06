using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayCommerceFundBindCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceFundBindCancelModel : AopObject
    {
        /// <summary>
        /// 需解绑的协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }
    }
}
