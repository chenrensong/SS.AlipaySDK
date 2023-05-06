using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFundWalletCardQueryResponse.
    /// </summary>
    public class AlipayFundWalletCardQueryResponse : AopResponse
    {
        /// <summary>
        /// 礼品卡对客展示
        /// </summary>
        [XmlArray("gift_card_vos")]
        [XmlArrayItem("gift_card_vo")]
        public List<GiftCardVo> GiftCardVos { get; set; }
    }
}
