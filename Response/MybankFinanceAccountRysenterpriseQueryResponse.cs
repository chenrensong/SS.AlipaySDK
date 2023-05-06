using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// MybankFinanceAccountRysenterpriseQueryResponse.
    /// </summary>
    public class MybankFinanceAccountRysenterpriseQueryResponse : AopResponse
    {
        /// <summary>
        /// 融易收账户Id
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 融易收账户可用余额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }
    }
}
