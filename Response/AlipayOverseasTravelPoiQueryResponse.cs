using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOverseasTravelPoiQueryResponse.
    /// </summary>
    public class AlipayOverseasTravelPoiQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝poi查询结果
        /// </summary>
        [XmlElement("poi_query_result")]
        public PoiQueryResult PoiQueryResult { get; set; }
    }
}
