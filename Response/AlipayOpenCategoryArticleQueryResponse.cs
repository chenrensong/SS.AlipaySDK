using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenCategoryArticleQueryResponse.
    /// </summary>
    public class AlipayOpenCategoryArticleQueryResponse : AopResponse
    {
        /// <summary>
        /// 文章列表
        /// </summary>
        [XmlArray("articles")]
        [XmlArrayItem("life_recommend_articles")]
        public List<LifeRecommendArticles> Articles { get; set; }
    }
}
