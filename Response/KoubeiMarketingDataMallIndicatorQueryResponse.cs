using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiMarketingDataMallIndicatorQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataMallIndicatorQueryResponse : AopResponse
    {
        /// <summary>
        /// JSON格式数组，每个对象表示一个门店某个具体日期的指标信息，KEY为指标代码，VALUE为该指标对应的值。注意返回的json数组和查询的字段biz_type的值的不同会有差异，并且返回值会直接展示返回对象的字段。对应关系为:  mallIndustryMemberStatistics ==> mall_industry_member_statistics  mallIndustryTradeStatistics ==> mall_industry_trade_statistics  mallIndustryEventStatistics ==> mall_industry_event_statistics  mallIndustryInfo ==> mall_industry_info  mallIndustryConsumptionStatistics ==> mall_industry_consumption_statistics
        /// </summary>
        [XmlElement("indicator_infos")]
        public string IndicatorInfos { get; set; }

        /// <summary>
        /// 总条目数,供计算分页信息使用
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
