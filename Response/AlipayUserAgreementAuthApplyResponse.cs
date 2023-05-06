using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserAgreementAuthApplyResponse.
    /// </summary>
    public class AlipayUserAgreementAuthApplyResponse : AopResponse
    {
        /// <summary>
        /// 鉴权申请token，其格式和内容，由支付宝定义。在鉴权确认的过程中，商户可根据申请操作成功时返回的申请token，进行后续的确认操作。
        /// </summary>
        [XmlElement("apply_token")]
        public string ApplyToken { get; set; }
    }
}
