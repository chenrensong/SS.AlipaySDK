using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusOdGetResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusOdGetResponse : AopResponse
    {
        /// <summary>
        /// od结果
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("cloud_bus_od_item")]
        public List<CloudBusOdItem> Result { get; set; }
    }
}
