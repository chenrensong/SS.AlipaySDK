using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerVersionproportionsetQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerVersionproportionsetQueryResponse : AopResponse
    {
        /// <summary>
        /// 版本
        /// </summary>
        [XmlElement("mini_appx_version")]
        public string MiniAppxVersion { get; set; }
    }
}
