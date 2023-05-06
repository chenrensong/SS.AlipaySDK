using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringCookConditionBatchqueryResponse.
    /// </summary>
    public class KoubeiCateringCookConditionBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 口碑菜谱模型列表
        /// </summary>
        [XmlElement("kb_dish_cook_page_info")]
        public PaginationCook KbDishCookPageInfo { get; set; }
    }
}
