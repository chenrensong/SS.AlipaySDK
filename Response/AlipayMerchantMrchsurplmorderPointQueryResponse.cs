using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMerchantMrchsurplmorderPointQueryResponse.
    /// </summary>
    public class AlipayMerchantMrchsurplmorderPointQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户当前的可用积分
        /// </summary>
        [XmlElement("point")]
        public long Point { get; set; }
    }
}
