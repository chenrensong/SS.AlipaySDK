using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceTransportParkingGoodsQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportParkingGoodsQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlElement("parking_goods_detail")]
        public ParkingGoodsDetail ParkingGoodsDetail { get; set; }
    }
}
