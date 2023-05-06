using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayFinanceFundFundprodQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinanceFundFundprodQueryModel : AopObject
    {
        /// <summary>
        /// 基金代码
        /// </summary>
        [XmlElement("fund_code")]
        public string FundCode { get; set; }
    }
}
