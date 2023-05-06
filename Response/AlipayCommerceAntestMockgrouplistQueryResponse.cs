using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceAntestMockgrouplistQueryResponse.
    /// </summary>
    public class AlipayCommerceAntestMockgrouplistQueryResponse : AopResponse
    {
        /// <summary>
        /// 挡板集列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("eco_mock_group_info")]
        public List<EcoMockGroupInfo> Data { get; set; }
    }
}
