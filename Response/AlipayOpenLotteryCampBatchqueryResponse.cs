using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenLotteryCampBatchqueryResponse.
    /// </summary>
    public class AlipayOpenLotteryCampBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 抽奖活动搜索列表
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
