using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsSceneEcommercePurchaseRecommendResponse.
    /// </summary>
    public class AlipayInsSceneEcommercePurchaseRecommendResponse : AopResponse
    {
        /// <summary>
        /// 推荐结果
        /// </summary>
        [XmlArray("recommend_results")]
        [XmlArrayItem("purchase_recomm_result_d_t_o")]
        public List<PurchaseRecommResultDTO> RecommendResults { get; set; }
    }
}
