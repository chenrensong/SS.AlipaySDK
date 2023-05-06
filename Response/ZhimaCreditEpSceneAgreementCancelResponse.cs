using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// ZhimaCreditEpSceneAgreementCancelResponse.
    /// </summary>
    public class ZhimaCreditEpSceneAgreementCancelResponse : AopResponse
    {
        /// <summary>
        /// 信用订单号
        /// </summary>
        [XmlElement("credit_order_no")]
        public string CreditOrderNo { get; set; }
    }
}
