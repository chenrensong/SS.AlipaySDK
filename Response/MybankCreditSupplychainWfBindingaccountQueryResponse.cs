using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// MybankCreditSupplychainWfBindingaccountQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainWfBindingaccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝id
        /// </summary>
        [XmlElement("alipayuserid")]
        public string Alipayuserid { get; set; }
    }
}
