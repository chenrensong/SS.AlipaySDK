using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceIotDeviceRecordsSetResponse.
    /// </summary>
    public class AlipayCommerceIotDeviceRecordsSetResponse : AopResponse
    {
        /// <summary>
        /// 设备档案
        /// </summary>
        [XmlElement("device_records")]
        public DeviceRecords DeviceRecords { get; set; }
    }
}
