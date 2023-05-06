using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignCashListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignCashListQueryModel : AopObject
    {
        /// <summary>
        /// 要查询的活动状态,不填默认为 ALL 返回所有类型。枚举支持: *ALL：所有类型的活动。 *CREATED：已创建未打款。 *PAID：已打款。 *READY：活动已开始。 *PAUSE：活动已暂停。 *CLOSED：活动已结束。 *SETTLE：活动已清算。
        /// </summary>
        [XmlElement("camp_status")]
        public string CampStatus { get; set; }

        /// <summary>
        /// 分页查询时的页码，从1开始
        /// </summary>
        [XmlElement("page_index")]
        public string PageIndex { get; set; }

        /// <summary>
        /// 分页查询时每页返回的列表大小，每页数据最大为 50。
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }
    }
}
