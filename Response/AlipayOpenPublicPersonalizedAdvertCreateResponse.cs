using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedAdvertCreateResponse.
    /// </summary>
    public class AlipayOpenPublicPersonalizedAdvertCreateResponse : AopResponse
    {
        /// <summary>
        /// 轮播广告分组id
        /// </summary>
        [XmlElement("advert_group")]
        public string AdvertGroup { get; set; }
    }
}
