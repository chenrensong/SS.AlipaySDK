using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandIotdeviceRecycleModifyResponse.
    /// </summary>
    public class AntMerchantExpandIotdeviceRecycleModifyResponse : AopResponse
    {
        /// <summary>
        /// 业务处理订单号
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }
    }
}
