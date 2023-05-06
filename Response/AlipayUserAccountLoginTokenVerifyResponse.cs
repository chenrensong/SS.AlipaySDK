using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserAccountLoginTokenVerifyResponse.
    /// </summary>
    public class AlipayUserAccountLoginTokenVerifyResponse : AopResponse
    {
        /// <summary>
        /// 支付宝用户uid
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }
    }
}
