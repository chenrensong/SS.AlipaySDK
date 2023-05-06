using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandExpressChangeSyncResponse.
    /// </summary>
    public class AntMerchantExpandExpressChangeSyncResponse : AopResponse
    {
        /// <summary>
        /// 响应参数
        /// </summary>
        [XmlElement("upload_result")]
        public AssetResult UploadResult { get; set; }
    }
}
