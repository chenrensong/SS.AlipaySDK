using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserGetResponse.
    /// </summary>
    public class AlipayUserGetResponse : AopResponse
    {
        /// <summary>
        /// 支付宝用户信息
        /// </summary>
        [XmlElement("alipay_user_detail")]
        public AlipayUserDetail AlipayUserDetail { get; set; }
    }
}
