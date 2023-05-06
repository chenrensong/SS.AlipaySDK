using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserAntpaasUseridGetResponse.
    /// </summary>
    public class AlipayUserAntpaasUseridGetResponse : AopResponse
    {
        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
