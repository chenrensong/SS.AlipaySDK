using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEcoPrinterStatusQueryResponse.
    /// </summary>
    public class AlipayEcoPrinterStatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 0离线 1在线 2缺纸
        /// </summary>
        [XmlElement("state")]
        public long State { get; set; }
    }
}
