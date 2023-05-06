using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// ZhimaCreditEpCreditlinkloanAuthorderSubmitResponse.
    /// </summary>
    public class ZhimaCreditEpCreditlinkloanAuthorderSubmitResponse : AopResponse
    {
        /// <summary>
        /// 商户单号，正常调用返回的数据和入参中的商户单号保持一致
        /// </summary>
        [XmlElement("merchant_biz_no")]
        public string MerchantBizNo { get; set; }
    }
}
