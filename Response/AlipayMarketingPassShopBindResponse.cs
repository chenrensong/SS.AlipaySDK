using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingPassShopBindResponse.
    /// </summary>
    public class AlipayMarketingPassShopBindResponse : AopResponse
    {
        /// <summary>
        /// 本次调用绑定的门店数量
        /// </summary>
        [XmlElement("binded")]
        public long Binded { get; set; }

        /// <summary>
        /// 绑定门店数的总计
        /// </summary>
        [XmlElement("total_binded")]
        public long TotalBinded { get; set; }
    }
}
