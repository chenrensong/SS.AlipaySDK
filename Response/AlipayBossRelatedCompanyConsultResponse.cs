using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossRelatedCompanyConsultResponse.
    /// </summary>
    public class AlipayBossRelatedCompanyConsultResponse : AopResponse
    {
        /// <summary>
        /// 关联交易公司甄别结果
        /// </summary>
        [XmlElement("result_set")]
        public InterTradeCompanyConsultOpenApiResult ResultSet { get; set; }
    }
}
