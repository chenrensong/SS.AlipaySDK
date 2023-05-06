using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceTransportTaxiHeatmapQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportTaxiHeatmapQueryResponse : AopResponse
    {
        /// <summary>
        /// 热力图数据 参见HeatMapData
        /// </summary>
        [XmlElement("heatmap_data")]
        public HeatMapData HeatmapData { get; set; }
    }
}
