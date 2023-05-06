using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusSchedualtasktimeQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusSchedualtasktimeQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ScheduleTimeResult Result { get; set; }
    }
}
