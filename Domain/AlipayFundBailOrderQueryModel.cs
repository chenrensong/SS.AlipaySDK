using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayFundBailOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundBailOrderQueryModel : AopObject
    {
        /// <summary>
        /// 代扣协议号，对应唯一的保证金代扣协议及保证金资金池
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }
    }
}
