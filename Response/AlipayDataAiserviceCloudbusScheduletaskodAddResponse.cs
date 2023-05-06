using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletaskodAddResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusScheduletaskodAddResponse : AopResponse
    {
        /// <summary>
        /// 任务结果
        /// </summary>
        [XmlElement("result")]
        public CloudbusCommonResult Result { get; set; }
    }
}
