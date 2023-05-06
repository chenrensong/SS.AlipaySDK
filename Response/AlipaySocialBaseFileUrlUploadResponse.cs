using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySocialBaseFileUrlUploadResponse.
    /// </summary>
    public class AlipaySocialBaseFileUrlUploadResponse : AopResponse
    {
        /// <summary>
        /// 文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
