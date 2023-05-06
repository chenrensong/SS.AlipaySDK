using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserDigitalidentityHealthcardQueryResponse.
    /// </summary>
    public class AlipayUserDigitalidentityHealthcardQueryResponse : AopResponse
    {
        /// <summary>
        /// 健康卡输出聚合信息
        /// </summary>
        [XmlElement("health_card_info")]
        public HealthCardInfo HealthCardInfo { get; set; }
    }
}
