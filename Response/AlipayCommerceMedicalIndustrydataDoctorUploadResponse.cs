using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataDoctorUploadResponse.
    /// </summary>
    public class AlipayCommerceMedicalIndustrydataDoctorUploadResponse : AopResponse
    {
        /// <summary>
        /// 业务响应数据
        /// </summary>
        [XmlElement("data")]
        public CommerceDataUploadResponseData Data { get; set; }
    }
}
