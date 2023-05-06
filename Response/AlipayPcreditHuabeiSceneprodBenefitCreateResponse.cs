using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiSceneprodBenefitCreateResponse.
    /// </summary>
    public class AlipayPcreditHuabeiSceneprodBenefitCreateResponse : AopResponse
    {
        /// <summary>
        /// 权益ID，创建成功后返回
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }
    }
}
