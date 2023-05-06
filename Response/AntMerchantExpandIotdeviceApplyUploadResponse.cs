using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandIotdeviceApplyUploadResponse.
    /// </summary>
    public class AntMerchantExpandIotdeviceApplyUploadResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁订单号
        /// </summary>
        [XmlElement("asset_apply_order_id")]
        public string AssetApplyOrderId { get; set; }
    }
}
