using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountOperateResponse.
    /// </summary>
    public class AlipayMarketingCampaignDiscountOperateResponse : AopResponse
    {
        /// <summary>
        /// 123
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }
    }
}
