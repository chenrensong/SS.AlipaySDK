using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 返回码 10000-成功 其他都是失败
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 返回消息
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 企业抬头信息
        /// </summary>
        [XmlArray("title_info_list")]
        [XmlArrayItem("enterprise_title_info")]
        public List<EnterpriseTitleInfo> TitleInfoList { get; set; }
    }
}
