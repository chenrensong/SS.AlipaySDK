using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenLotteryRegionGetResponse.
    /// </summary>
    public class AlipayOpenLotteryRegionGetResponse : AopResponse
    {
        /// <summary>
        /// 入驻商家专区信息
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
