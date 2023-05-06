using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossProdAlcagmprodAgreementUnsignResponse.
    /// </summary>
    public class AlipayBossProdAlcagmprodAgreementUnsignResponse : AopResponse
    {
        /// <summary>
        /// 是否处理成功
        /// </summary>
        [XmlElement("result_success")]
        public bool ResultSuccess { get; set; }

        /// <summary>
        /// traceId，方便排查问题
        /// </summary>
        [XmlElement("result_trace_id")]
        public string ResultTraceId { get; set; }
    }
}
