using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayZdatafrontDatatransferedSendResponse.
    /// </summary>
    public class AlipayZdatafrontDatatransferedSendResponse : AopResponse
    {
        /// <summary>
        /// 表示数据传输是否成功
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
