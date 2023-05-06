using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// NiukeExamReportCallbackResult Data Structure.
    /// </summary>
    [Serializable]
    public class NiukeExamReportCallbackResult : AopObject
    {
        /// <summary>
        /// 调用结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
