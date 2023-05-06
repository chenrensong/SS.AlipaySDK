using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceOperationIsvOrderSyncResponse.
    /// </summary>
    public class AlipayCommerceOperationIsvOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步订单记录id
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }
    }
}
