using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayIserviceCcmLcsServicemodelSetResponse.
    /// </summary>
    public class AlipayIserviceCcmLcsServicemodelSetResponse : AopResponse
    {
        /// <summary>
        /// 操作返回结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
