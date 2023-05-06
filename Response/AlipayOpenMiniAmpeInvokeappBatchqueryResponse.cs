using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeInvokeappBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeInvokeappBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 调用应用信息列表
        /// </summary>
        [XmlArray("invoke_app_list")]
        [XmlArrayItem("invoke_app_info")]
        public List<InvokeAppInfo> InvokeAppList { get; set; }
    }
}
