using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceIotDeviceTraceQueryResponse.
    /// </summary>
    public class AlipayCommerceIotDeviceTraceQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回了这段时间内设备的轨迹
        /// </summary>
        [XmlElement("trace")]
        public string Trace { get; set; }
    }
}
