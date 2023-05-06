using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserInfoDesignatedShareResponse.
    /// </summary>
    public class AlipayUserInfoDesignatedShareResponse : AopResponse
    {
        /// <summary>
        /// 用户授权给三方的借记卡相关信息
        /// </summary>
        [XmlElement("debit_card_info")]
        public UserDebitCardInfo DebitCardInfo { get; set; }
    }
}
