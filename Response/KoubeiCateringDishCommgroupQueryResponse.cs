using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringDishCommgroupQueryResponse.
    /// </summary>
    public class KoubeiCateringDishCommgroupQueryResponse : AopResponse
    {
        /// <summary>
        /// 客制化组分页信息
        /// </summary>
        [XmlElement("kb_dish_group_page_info")]
        public PaginationCommGroup KbDishGroupPageInfo { get; set; }
    }
}
