using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdCreativeQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportAdCreativeQueryResponse : AopResponse
    {
        /// <summary>
        /// 广告创意详情；是否唯一(不需要)；用于通过创意ID查询创意详情；admgr广告创意查询返回
        /// </summary>
        [XmlElement("ad_creative_result")]
        public AdCreativeResult AdCreativeResult { get; set; }
    }
}
