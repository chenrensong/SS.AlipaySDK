using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFinanceFundFundFixedprofitQueryResponse.
    /// </summary>
    public class AlipayFinanceFundFundFixedprofitQueryResponse : AopResponse
    {
        /// <summary>
        /// 过去5年定投收益率
        /// </summary>
        [XmlElement("last_five_year")]
        public string LastFiveYear { get; set; }

        /// <summary>
        /// 近一年定投收益率
        /// </summary>
        [XmlElement("last_one_year")]
        public string LastOneYear { get; set; }

        /// <summary>
        /// 最近三年定投收益率
        /// </summary>
        [XmlElement("last_three_year")]
        public string LastThreeYear { get; set; }

        /// <summary>
        /// 过去2年定投收益率
        /// </summary>
        [XmlElement("last_two_year")]
        public string LastTwoYear { get; set; }

        /// <summary>
        /// 自从成立以来
        /// </summary>
        [XmlElement("since_establish")]
        public string SinceEstablish { get; set; }
    }
}
