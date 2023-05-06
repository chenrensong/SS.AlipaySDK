using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserAccountNewbieBenefitConsultResponse.
    /// </summary>
    public class AlipayUserAccountNewbieBenefitConsultResponse : AopResponse
    {
        /// <summary>
        /// 脱敏后的支付宝登录号
        /// </summary>
        [XmlElement("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 权益信息
        /// </summary>
        [XmlElement("benefit_info")]
        public AntMemberBenefitInfo BenefitInfo { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 本次请求是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
