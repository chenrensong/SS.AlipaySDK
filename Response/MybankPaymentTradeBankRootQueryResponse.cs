using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// MybankPaymentTradeBankRootQueryResponse.
    /// </summary>
    public class MybankPaymentTradeBankRootQueryResponse : AopResponse
    {
        /// <summary>
        /// Institution列表
        /// </summary>
        [XmlArray("bank_details")]
        [XmlArrayItem("institution")]
        public List<Institution> BankDetails { get; set; }
    }
}
