using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AntlawSignOperator Data Structure.
    /// </summary>
    [Serializable]
    public class AntlawSignOperator : AopObject
    {
        /// <summary>
        /// 证件类型，包括IDENTIFY（身份证号），USCC（统一社会信用码）
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 签约人证件号，个人为身份证号，企业为统一社会信用编码
        /// </summary>
        [XmlElement("operator_cert_no")]
        public string OperatorCertNo { get; set; }

        /// <summary>
        /// 签约机构或签约个人名称
        /// </summary>
        [XmlElement("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 签约人为个人时，需要提供签约人的支付宝uid
        /// </summary>
        [XmlElement("operator_uid")]
        public string OperatorUid { get; set; }

        /// <summary>
        /// 签约人类型，个人（PERSON ）还是企业（ENTERPRISE）
        /// </summary>
        [XmlElement("sign_operator_type")]
        public string SignOperatorType { get; set; }
    }
}
