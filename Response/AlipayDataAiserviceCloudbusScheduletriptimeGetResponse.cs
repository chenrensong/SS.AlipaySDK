using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletriptimeGetResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusScheduletriptimeGetResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ScheduleTripResult Result { get; set; }
    }
}
