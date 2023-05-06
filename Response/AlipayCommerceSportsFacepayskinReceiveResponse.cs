using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceSportsFacepayskinReceiveResponse.
    /// </summary>
    public class AlipayCommerceSportsFacepayskinReceiveResponse : AopResponse
    {
        /// <summary>
        /// 用户付款码皮肤信息
        /// </summary>
        [XmlElement("data")]
        public UserFacePaySkinInfo Data { get; set; }
    }
}
