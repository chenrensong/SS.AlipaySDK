using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletaskshiftQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusScheduletaskshiftQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ScheduleShiftResult Result { get; set; }
    }
}
