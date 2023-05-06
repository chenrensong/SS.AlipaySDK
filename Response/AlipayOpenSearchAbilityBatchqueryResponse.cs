using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenSearchAbilityBatchqueryResponse.
    /// </summary>
    public class AlipayOpenSearchAbilityBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 搜索运营分页数据
        /// </summary>
        [XmlElement("data")]
        public AbilityPageQueryDTO Data { get; set; }
    }
}
