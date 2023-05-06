using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEcoMycarDataserviceMaintainvehicleShareResponse.
    /// </summary>
    public class AlipayEcoMycarDataserviceMaintainvehicleShareResponse : AopResponse
    {
        /// <summary>
        /// 车辆详细信息
        /// </summary>
        [XmlElement("info")]
        public MaintainVehicleInfo Info { get; set; }
    }
}
