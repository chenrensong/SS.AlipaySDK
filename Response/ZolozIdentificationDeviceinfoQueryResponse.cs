using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// ZolozIdentificationDeviceinfoQueryResponse.
    /// </summary>
    public class ZolozIdentificationDeviceinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// device_info
        /// </summary>
        [XmlElement("device_info")]
        public ZolozDeviceInfo DeviceInfo { get; set; }
    }
}
