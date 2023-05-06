using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataDataserviceIcrowdUseResponse.
    /// </summary>
    public class AlipayDataDataserviceIcrowdUseResponse : AopResponse
    {
        /// <summary>
        /// 接口返回内容
        /// </summary>
        [XmlElement("icrowd_use_resp")]
        public IcrowdUseResp IcrowdUseResp { get; set; }
    }
}
