using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySocialBaseMessageDynamicicondataModifyResponse.
    /// </summary>
    public class AlipaySocialBaseMessageDynamicicondataModifyResponse : AopResponse
    {
        /// <summary>
        /// 此次操作结果
        /// </summary>
        [XmlElement("op_result")]
        public bool OpResult { get; set; }
    }
}
