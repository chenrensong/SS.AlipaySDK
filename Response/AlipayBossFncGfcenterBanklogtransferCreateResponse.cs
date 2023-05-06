using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossFncGfcenterBanklogtransferCreateResponse.
    /// </summary>
    public class AlipayBossFncGfcenterBanklogtransferCreateResponse : AopResponse
    {
        /// <summary>
        /// 银行流水认领返回结果
        /// </summary>
        [XmlElement("result_set")]
        public JsonOpenApiVO ResultSet { get; set; }
    }
}
