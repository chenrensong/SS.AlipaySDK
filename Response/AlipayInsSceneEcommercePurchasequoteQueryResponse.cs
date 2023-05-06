using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsSceneEcommercePurchasequoteQueryResponse.
    /// </summary>
    public class AlipayInsSceneEcommercePurchasequoteQueryResponse : AopResponse
    {
        /// <summary>
        /// 订购查询结果
        /// </summary>
        [XmlArray("purchase_query_results")]
        [XmlArrayItem("purchase_query_result_d_t_o")]
        public List<PurchaseQueryResultDTO> PurchaseQueryResults { get; set; }
    }
}
