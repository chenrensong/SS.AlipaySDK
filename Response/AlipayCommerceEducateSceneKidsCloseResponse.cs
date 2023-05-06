using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEducateSceneKidsCloseResponse.
    /// </summary>
    public class AlipayCommerceEducateSceneKidsCloseResponse : AopResponse
    {
        /// <summary>
        /// 关闭业务是否成功
        /// </summary>
        [XmlElement("close_success")]
        public string CloseSuccess { get; set; }
    }
}
