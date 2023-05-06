using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerCampaignauditQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerCampaignauditQueryResponse : AopResponse
    {
        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
