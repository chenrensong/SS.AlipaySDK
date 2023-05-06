using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAuthUserauthRelationshipCertifyResponse.
    /// </summary>
    public class AlipayOpenAuthUserauthRelationshipCertifyResponse : AopResponse
    {
        /// <summary>
        /// 授权关系有效性校验，true:有效，false:无效
        /// </summary>
        [XmlElement("effective")]
        public bool Effective { get; set; }
    }
}
