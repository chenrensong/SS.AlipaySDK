using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserTwostageCommonUseResponse.
    /// </summary>
    public class AlipayUserTwostageCommonUseResponse : AopResponse
    {
        /// <summary>
        /// open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户userId信息，因为用户已经在客户端给商户的小程序授权了，并且商户要通过userId信息挂接优惠券信息，所以可以无需脱敏返回给商户。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 从码值解析出来的用户身份信息
        /// </summary>
        [XmlElement("user_identity_info")]
        public UserIdentityInfo UserIdentityInfo { get; set; }
    }
}