using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeDevicetypeBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeDevicetypeBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 设备类型列表
        /// </summary>
        [XmlArray("device_type_list")]
        [XmlArrayItem("ampe_device_type_info")]
        public List<AmpeDeviceTypeInfo> DeviceTypeList { get; set; }
    }
}
