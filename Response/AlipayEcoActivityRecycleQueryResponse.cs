using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEcoActivityRecycleQueryResponse.
    /// </summary>
    public class AlipayEcoActivityRecycleQueryResponse : AopResponse
    {
        /// <summary>
        /// 能量返回结果列表
        /// </summary>
        [XmlArray("energy_list")]
        [XmlArrayItem("energy_query_rsp")]
        public List<EnergyQueryRsp> EnergyList { get; set; }
    }
}
