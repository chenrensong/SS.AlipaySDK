using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossProdAntsignUserCreateResponse.
    /// </summary>
    public class AlipayBossProdAntsignUserCreateResponse : AopResponse
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("sign_user_unique_id")]
        public string SignUserUniqueId { get; set; }
    }
}
