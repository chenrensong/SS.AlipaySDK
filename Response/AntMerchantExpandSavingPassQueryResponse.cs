using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AntMerchantExpandSavingPassQueryResponse.
    /// </summary>
    public class AntMerchantExpandSavingPassQueryResponse : AopResponse
    {
        /// <summary>
        /// 省卡咨询结果可购买的商品信息
        /// </summary>
        [XmlArray("card_list")]
        [XmlArrayItem("s_card_query_v_o")]
        public List<SCardQueryVO> CardList { get; set; }

        /// <summary>
        /// 是否可以购买省卡
        /// </summary>
        [XmlElement("enable")]
        public bool Enable { get; set; }
    }
}
