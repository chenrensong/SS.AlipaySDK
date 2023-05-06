using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBusinessRelationShopdetailQueryResponse.
    /// </summary>
    public class AlipayBusinessRelationShopdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 门店详情信息
        /// </summary>
        [XmlElement("shop_info")]
        public BusinessRelationShopDetailInfo ShopInfo { get; set; }
    }
}
