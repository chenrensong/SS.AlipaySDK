using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerCampaignOfflineResponse.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerCampaignOfflineResponse : AopResponse
    {
        /// <summary>
        /// 状态。P(审核中)、S(审核通过)、F(审核驳回)、I(初始状态)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
