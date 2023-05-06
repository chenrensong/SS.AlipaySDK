using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringDishConditionBatchqueryResponse.
    /// </summary>
    public class KoubeiCateringDishConditionBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 菜品分页信息
        /// </summary>
        [XmlElement("kb_dish_page_info")]
        public PaginationDish KbDishPageInfo { get; set; }
    }
}
