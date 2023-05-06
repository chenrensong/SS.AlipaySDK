using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFundCouponWufuHdaipictureCreateResponse.
    /// </summary>
    public class AlipayFundCouponWufuHdaipictureCreateResponse : AopResponse
    {
        /// <summary>
        /// 高清图ID
        /// </summary>
        [XmlElement("hd_image_id")]
        public string HdImageId { get; set; }
    }
}
