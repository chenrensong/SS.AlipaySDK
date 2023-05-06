using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletaskodQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusScheduletaskodQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ScheduleOdResult Result { get; set; }
    }
}
