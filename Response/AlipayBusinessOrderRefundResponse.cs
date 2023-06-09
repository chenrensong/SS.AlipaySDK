using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBusinessOrderRefundResponse.
    /// </summary>
    public class AlipayBusinessOrderRefundResponse : AopResponse
    {
        /// <summary>
        /// 商户外部订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单累计退款金额。单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("order_refund_amount")]
        public string OrderRefundAmount { get; set; }

        /// <summary>
        /// 本次退款支付工具明细列表
        /// </summary>
        [XmlArray("refund_paytool_list")]
        [XmlArrayItem("paytool_refund_result_detail")]
        public List<PaytoolRefundResultDetail> RefundPaytoolList { get; set; }
    }
}
