using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayIserviceItaskMerchantRecordSyncResponse.
    /// </summary>
    public class AlipayIserviceItaskMerchantRecordSyncResponse : AopResponse
    {
        /// <summary>
        /// 业务入参的biz_id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
