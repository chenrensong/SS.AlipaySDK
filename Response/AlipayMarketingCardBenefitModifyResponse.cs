using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingCardBenefitModifyResponse.
    /// </summary>
    public class AlipayMarketingCardBenefitModifyResponse : AopResponse
    {
        /// <summary>
        /// 权益修改结果；true成功：false失败
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
