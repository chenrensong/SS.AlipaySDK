using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionDevicegrayQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionDevicegrayQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备号列表
        /// </summary>
        [XmlArray("device_no_list")]
        [XmlArrayItem("string")]
        public List<string> DeviceNoList { get; set; }

        /// <summary>
        /// 分组信息列表
        /// </summary>
        [XmlArray("gray_groups")]
        [XmlArrayItem("mini_app_gray_group_dto")]
        public List<MiniAppGrayGroupDto> GrayGroups { get; set; }

        /// <summary>
        /// 分组名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
