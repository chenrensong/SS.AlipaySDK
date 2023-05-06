using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// EpCreditLinkCreateQueryDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpCreditLinkCreateQueryDataInfo : AopObject
    {
        /// <summary>
        /// 信用等级结果
        /// </summary>
        [XmlElement("cr_result")]
        public CreditRateResult CrResult { get; set; }
    }
}
