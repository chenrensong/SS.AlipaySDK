using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// PaytoolCancelRequestDetail Data Structure.
    /// </summary>
    [Serializable]
    public class PaytoolCancelRequestDetail : AopObject
    {
        /// <summary>
        /// 支付宝支付工具单据号，与商户支付工具单据号不能同时为空。
        /// </summary>
        [XmlElement("paytool_bill_no")]
        public string PaytoolBillNo { get; set; }

        /// <summary>
        /// 商户外部支付工具单据号，与支付宝支付工具单据号不能同时为空
        /// </summary>
        [XmlElement("paytool_request_no")]
        public string PaytoolRequestNo { get; set; }
    }
}
