using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceFixAttachmentUploadResponse.
    /// </summary>
    public class AlipayCommerceFixAttachmentUploadResponse : AopResponse
    {
        /// <summary>
        /// 上传文件的内容。
        /// </summary>
        [XmlElement("file_info")]
        public FixFileInfo FileInfo { get; set; }
    }
}
