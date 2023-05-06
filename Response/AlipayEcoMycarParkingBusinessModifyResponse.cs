using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingBusinessModifyResponse.
    /// </summary>
    public class AlipayEcoMycarParkingBusinessModifyResponse : AopResponse
    {
        /// <summary>
        /// 接口调用结果:0成功，1失败
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
