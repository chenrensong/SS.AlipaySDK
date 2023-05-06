using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseAgreementQueryResponse.
    /// </summary>
    public class AlipayCommerceEcEnterpriseAgreementQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业签约信息
        /// </summary>
        [XmlElement("enterprise_agreement_dto")]
        public EnterpriseAgreementDTO EnterpriseAgreementDto { get; set; }
    }
}
