using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceFileUploadResponse.
    /// </summary>
    public class AnttechBlockchainFinanceFileUploadResponse : AopResponse
    {
        /// <summary>
        /// 上传成功后返回文件信息
        /// </summary>
        [XmlElement("file_info")]
        public FinanceFileInfo FileInfo { get; set; }
    }
}
