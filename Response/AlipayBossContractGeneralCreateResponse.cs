using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossContractGeneralCreateResponse.
    /// </summary>
    public class AlipayBossContractGeneralCreateResponse : AopResponse
    {
        /// <summary>
        /// 发起审批返回结果
        /// </summary>
        [XmlElement("result_set")]
        public InterTradetContractOpenApiStartResult ResultSet { get; set; }
    }
}
