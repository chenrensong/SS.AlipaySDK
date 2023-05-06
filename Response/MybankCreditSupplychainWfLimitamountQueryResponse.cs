using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// MybankCreditSupplychainWfLimitamountQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainWfLimitamountQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否准入
        /// </summary>
        [XmlElement("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 盖帽额度
        /// </summary>
        [XmlElement("limitamt")]
        public AmountWf Limitamt { get; set; }
    }
}
