using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppProdmodeProvcityQueryResponse.
    /// </summary>
    public class AlipayEbppProdmodeProvcityQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回省市下拉列表数据
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("query_prov_city_info")]
        public List<QueryProvCityInfo> DataList { get; set; }
    }
}
