using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceIotDeviceReportUploadResponse.
    /// </summary>
    public class AlipayCommerceIotDeviceReportUploadResponse : AopResponse
    {
        /// <summary>
        /// 是否上传成功
        /// </summary>
        [XmlElement("status")]
        public bool Status { get; set; }
    }
}
