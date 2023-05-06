using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusSchedualconfigSetResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusSchedualconfigSetResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ScheduleConfigResult Result { get; set; }
    }
}
