using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringPosStalldetailQueryResponse.
    /// </summary>
    public class KoubeiCateringPosStalldetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 档口模型
        /// </summary>
        [XmlElement("stall_entity")]
        public StallEntity StallEntity { get; set; }
    }
}
