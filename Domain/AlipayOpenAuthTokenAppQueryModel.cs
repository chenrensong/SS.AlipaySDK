using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenAuthTokenAppQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthTokenAppQueryModel : AopObject
    {
        /// <summary>
        /// 应用授权令牌
        /// </summary>
        [XmlElement("app_auth_token")]
        public string AppAuthToken { get; set; }
    }
}
