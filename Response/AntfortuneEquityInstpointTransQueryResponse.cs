using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntfortuneEquityInstpointTransQueryResponse.
    /// </summary>
    public class AntfortuneEquityInstpointTransQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询到的结果
        /// </summary>
        [XmlArray("trans_info")]
        [XmlArrayItem("point_trans_info")]
        public List<PointTransInfo> TransInfo { get; set; }
    }
}
