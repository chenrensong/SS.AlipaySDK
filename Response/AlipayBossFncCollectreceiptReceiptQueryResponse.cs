using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossFncCollectreceiptReceiptQueryResponse.
    /// </summary>
    public class AlipayBossFncCollectreceiptReceiptQueryResponse : AopResponse
    {
        /// <summary>
        /// 收款单openapi分页返回DTO
        /// </summary>
        [XmlElement("result_set")]
        public CollectReceiptOpenApiPageDTO ResultSet { get; set; }
    }
}
