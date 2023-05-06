using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossProdSubaccountBalanceQueryResponse.
    /// </summary>
    public class AlipayBossProdSubaccountBalanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 子户余额信息
        /// </summary>
        [XmlElement("result_set")]
        public SubAccountBalanceOpenApiDTO ResultSet { get; set; }
    }
}
