using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusSchedualtaskQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusSchedualtaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ScheduleWorkResult Result { get; set; }
    }
}
