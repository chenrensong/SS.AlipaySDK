using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringPosDishBatchqueryResponse.
    /// </summary>
    public class KoubeiCateringPosDishBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 菜谱中的菜品的列表
        /// </summary>
        [XmlElement("cook_dish")]
        public PosCookDishQryModel CookDish { get; set; }
    }
}
