using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserAuthSecondpartyTokenVerifyResponse.
    /// </summary>
    public class AlipayUserAuthSecondpartyTokenVerifyResponse : AopResponse
    {
        /// <summary>
        /// 淘宝用户id
        /// </summary>
        [XmlElement("tb_user_id")]
        public string TbUserId { get; set; }
    }
}
