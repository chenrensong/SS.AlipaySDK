using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceIotDapplyOrderdeviceQueryResponse.
    /// </summary>
    public class AlipayCommerceIotDapplyOrderdeviceQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备信息列表
        /// </summary>
        [XmlArray("device_infos")]
        [XmlArrayItem("device_apply_order_device_model")]
        public List<DeviceApplyOrderDeviceModel> DeviceInfos { get; set; }
    }
}
