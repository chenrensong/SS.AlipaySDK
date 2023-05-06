using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataHospitalUploadResponse.
    /// </summary>
    public class AlipayCommerceMedicalIndustrydataHospitalUploadResponse : AopResponse
    {
        /// <summary>
        /// 响应数据
        /// </summary>
        [XmlElement("data")]
        public CommerceDataUploadResponseData Data { get; set; }
    }
}
