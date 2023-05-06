using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayToolsFileUploadResponse.
    /// </summary>
    public class AlipayToolsFileUploadResponse : AopResponse
    {
        /// <summary>
        /// 文件地址
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
