using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiTradeBillDownloadurlQueryResponse.
    /// </summary>
    public class KoubeiTradeBillDownloadurlQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单下载地址
        /// </summary>
        [XmlElement("bill_download_url")]
        public string BillDownloadUrl { get; set; }
    }
}
