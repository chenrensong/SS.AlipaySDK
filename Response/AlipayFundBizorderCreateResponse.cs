using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFundBizorderCreateResponse.
    /// </summary>
    public class AlipayFundBizorderCreateResponse : AopResponse
    {
        /// <summary>
        /// 支付宝业务订单号
        /// </summary>
        [XmlElement("biz_order_no")]
        public string BizOrderNo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 业务单据状态。  WAIT_PAY：待支付；  DEALING：支付处理中；  SUCCESS：已支付；  CLOSE：已废弃；  OFFLINE_PAY：线下已付。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
