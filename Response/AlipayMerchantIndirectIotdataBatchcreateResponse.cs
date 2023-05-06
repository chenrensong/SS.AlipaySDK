using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMerchantIndirectIotdataBatchcreateResponse.
    /// </summary>
    public class AlipayMerchantIndirectIotdataBatchcreateResponse : AopResponse
    {
        /// <summary>
        /// 失败记录详情
        /// </summary>
        [XmlArray("fail_detail")]
        [XmlArrayItem("speech_record_report_fail_detail")]
        public List<SpeechRecordReportFailDetail> FailDetail { get; set; }

        /// <summary>
        /// 上报成功条数
        /// </summary>
        [XmlElement("success_count")]
        public long SuccessCount { get; set; }
    }
}
