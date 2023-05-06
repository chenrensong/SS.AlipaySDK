using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEcoEduKtZftschoolModifyResponse.
    /// </summary>
    public class AlipayEcoEduKtZftschoolModifyResponse : AopResponse
    {
        /// <summary>
        /// 进件单号id，查询进件接口输入参数
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
