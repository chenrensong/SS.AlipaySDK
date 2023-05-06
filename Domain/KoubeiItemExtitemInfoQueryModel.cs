using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// KoubeiItemExtitemInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiItemExtitemInfoQueryModel : AopObject
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }
    }
}
