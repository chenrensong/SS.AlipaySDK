using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceIotDeviceBaseinfoQueryResponse.
    /// </summary>
    public class AlipayCommerceIotDeviceBaseinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备ID，biztid
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }
    }
}
