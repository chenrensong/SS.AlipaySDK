using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFinanceFundSimilarquotationQueryResponse.
    /// </summary>
    public class AlipayFinanceFundSimilarquotationQueryResponse : AopResponse
    {
        /// <summary>
        /// 近半年的参与同类收益率排名的基金数量
        /// </summary>
        [XmlElement("last_half_year_count")]
        public string LastHalfYearCount { get; set; }

        /// <summary>
        /// 近半年的同类收益率的排名
        /// </summary>
        [XmlElement("last_half_year_order")]
        public string LastHalfYearOrder { get; set; }

        /// <summary>
        /// 近半年的同类收益率；四舍五入后保留小数点后4位
        /// </summary>
        [XmlElement("last_half_year_similar")]
        public string LastHalfYearSimilar { get; set; }

        /// <summary>
        /// 近一月的参与同类收益率排名的基金数量
        /// </summary>
        [XmlElement("last_month_count")]
        public string LastMonthCount { get; set; }

        /// <summary>
        /// 近一月的同类收益率的排名
        /// </summary>
        [XmlElement("last_month_order")]
        public string LastMonthOrder { get; set; }

        /// <summary>
        /// 近一月的同类收益率；四舍五入后保留小数点后4位
        /// </summary>
        [XmlElement("last_month_similar")]
        public string LastMonthSimilar { get; set; }

        /// <summary>
        /// 近一季度的参与同类收益率排名的基金数量
        /// </summary>
        [XmlElement("last_quarter_count")]
        public string LastQuarterCount { get; set; }

        /// <summary>
        /// 近一季度的同类收益率的排名
        /// </summary>
        [XmlElement("last_quarter_order")]
        public string LastQuarterOrder { get; set; }

        /// <summary>
        /// 近一季度的同类收益率；四舍五入后保留小数点后4位
        /// </summary>
        [XmlElement("last_quarter_similar")]
        public string LastQuarterSimilar { get; set; }

        /// <summary>
        /// 近一年的参与同类收益率排名的基金数量
        /// </summary>
        [XmlElement("last_year_count")]
        public string LastYearCount { get; set; }

        /// <summary>
        /// 近一年的同类收益率排名
        /// </summary>
        [XmlElement("last_year_order")]
        public string LastYearOrder { get; set; }

        /// <summary>
        /// 近一年的同类收益率；四舍五入后保留小数点后4位
        /// </summary>
        [XmlElement("last_year_similar")]
        public string LastYearSimilar { get; set; }

        /// <summary>
        /// 发布日期；同类收益率发布的时间
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 近三年的参与同类收益率排名的基金数量
        /// </summary>
        [XmlElement("yield_three_year_count")]
        public string YieldThreeYearCount { get; set; }

        /// <summary>
        /// 近三年的同类收益率的排名
        /// </summary>
        [XmlElement("yield_three_year_order")]
        public string YieldThreeYearOrder { get; set; }

        /// <summary>
        /// 近三年的同类收益率；四舍五入后保留小数点后4位
        /// </summary>
        [XmlElement("yield_three_year_similar")]
        public string YieldThreeYearSimilar { get; set; }
    }
}
