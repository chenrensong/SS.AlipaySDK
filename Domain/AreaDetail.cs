using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AreaDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AreaDetail : AopObject
    {
        /// <summary>
        /// 国标六位行政区划代码；参考http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/。当area_name为“其他”等时该字段可能为空
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 行政区划名称；参考http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/。注意，该字段可能存在“其他”、“未知”等
        /// </summary>
        [XmlElement("area_name")]
        public string AreaName { get; set; }

        /// <summary>
        /// 小程序在该区域下的pv
        /// </summary>
        [XmlElement("area_pv")]
        public long AreaPv { get; set; }

        /// <summary>
        /// 小程序在该区域下的uv
        /// </summary>
        [XmlElement("area_uv")]
        public long AreaUv { get; set; }
    }
}
