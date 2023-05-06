using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenLotteryRegionBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenLotteryRegionBatchqueryModel : AopObject
    {
        /// <summary>
        /// 环境
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }
    }
}
