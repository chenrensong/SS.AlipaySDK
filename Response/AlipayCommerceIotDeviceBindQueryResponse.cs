using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceIotDeviceBindQueryResponse.
    /// </summary>
    public class AlipayCommerceIotDeviceBindQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备绑定关系
        /// </summary>
        [XmlArray("bind_info_list")]
        [XmlArrayItem("iot_device_bind_info")]
        public List<IotDeviceBindInfo> BindInfoList { get; set; }
    }
}
