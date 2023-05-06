using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenLotteryCampdeliverModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenLotteryCampdeliverModifyModel : AopObject
    {
        /// <summary>
        /// 环境
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }
    }
}
