using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthEcsignErrorQueryResponse.
    /// </summary>
    public class AlipayFinancialnetAuthEcsignErrorQueryResponse : AopResponse
    {
        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlArray("error_log_list")]
        [XmlArrayItem("error_log")]
        public List<ErrorLog> ErrorLogList { get; set; }
    }
}
