using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFinanceQuotationProtocolAuthorizeCheckResponse.
    /// </summary>
    public class AlipayFinanceQuotationProtocolAuthorizeCheckResponse : AopResponse
    {
        /// <summary>
        /// 协议最终是否订阅的结果
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("sub_protocol_result")]
        public List<SubProtocolResult> Result { get; set; }
    }
}
