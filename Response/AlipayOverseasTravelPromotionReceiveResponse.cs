using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOverseasTravelPromotionReceiveResponse.
    /// </summary>
    public class AlipayOverseasTravelPromotionReceiveResponse : AopResponse
    {
        /// <summary>
        /// 券平台领券成功的券id
        /// </summary>
        [XmlElement("out_prize_id")]
        public string OutPrizeId { get; set; }
    }
}
