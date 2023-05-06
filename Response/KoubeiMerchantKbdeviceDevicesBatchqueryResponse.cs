using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiMerchantKbdeviceDevicesBatchqueryResponse.
    /// </summary>
    public class KoubeiMerchantKbdeviceDevicesBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 门店下设备列表
        /// </summary>
        [XmlArray("device_info_list")]
        [XmlArrayItem("device_info")]
        public List<DeviceInfo> DeviceInfoList { get; set; }
    }
}
