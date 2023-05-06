using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerCampaignQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerCampaignQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动信息
        /// </summary>
        [XmlElement("market_info")]
        public MarketInfo MarketInfo { get; set; }
    }
}
