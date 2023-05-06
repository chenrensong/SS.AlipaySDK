using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// HotelStatusInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HotelStatusInfo : AopObject
    {
        /// <summary>
        /// 口碑门店id/飞猪景点id/飞猪酒店id
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }
    }
}
