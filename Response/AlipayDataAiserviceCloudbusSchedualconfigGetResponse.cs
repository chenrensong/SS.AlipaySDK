using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusSchedualconfigGetResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusSchedualconfigGetResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public ScheduleConfigGetResult Result { get; set; }
    }
}
