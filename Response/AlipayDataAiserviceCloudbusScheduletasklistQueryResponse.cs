using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletasklistQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusScheduletasklistQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ScheduleListResult Result { get; set; }
    }
}
