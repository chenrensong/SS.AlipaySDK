using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandAttachmentUploadSyncResponse.
    /// </summary>
    public class AntMerchantExpandAttachmentUploadSyncResponse : AopResponse
    {
        /// <summary>
        /// 响应结果
        /// </summary>
        [XmlElement("upload_result")]
        public AssetResult UploadResult { get; set; }
    }
}
