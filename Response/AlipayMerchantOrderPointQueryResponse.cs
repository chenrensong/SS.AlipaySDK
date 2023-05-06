using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMerchantOrderPointQueryResponse.
    /// </summary>
    public class AlipayMerchantOrderPointQueryResponse : AopResponse
    {
        /// <summary>
        /// 所查询积分类型的积分余额
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }
    }
}
