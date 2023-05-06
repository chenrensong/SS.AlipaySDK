using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenLotteryRegionGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenLotteryRegionGetModel : AopObject
    {
        /// <summary>
        /// 环境
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }
    }
}
