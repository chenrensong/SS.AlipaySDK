using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenLotteryCampresultQueryResponse.
    /// </summary>
    public class AlipayOpenLotteryCampresultQueryResponse : AopResponse
    {
        /// <summary>
        /// 中奖结果名单
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
