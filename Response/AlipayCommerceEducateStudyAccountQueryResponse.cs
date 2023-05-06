using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEducateStudyAccountQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateStudyAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户的学习账户信息
        /// </summary>
        [XmlElement("alipay_card_list")]
        public StudyAccountInfo AlipayCardList { get; set; }
    }
}
