using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusTimeodGetResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusTimeodGetResponse : AopResponse
    {
        /// <summary>
        /// od分时结果列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("cloudbus_time_od_item")]
        public List<CloudbusTimeOdItem> Result { get; set; }
    }
}
