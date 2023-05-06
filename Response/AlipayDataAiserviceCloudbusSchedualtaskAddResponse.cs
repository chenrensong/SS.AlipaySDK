using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusSchedualtaskAddResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusSchedualtaskAddResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public CloudbusCommonResult Result { get; set; }
    }
}
