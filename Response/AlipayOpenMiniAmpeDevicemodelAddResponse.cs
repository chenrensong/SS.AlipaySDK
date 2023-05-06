using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeDevicemodelAddResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeDevicemodelAddResponse : AopResponse
    {
        /// <summary>
        /// 设备机型id
        /// </summary>
        [XmlElement("device_model_id")]
        public long DeviceModelId { get; set; }
    }
}
