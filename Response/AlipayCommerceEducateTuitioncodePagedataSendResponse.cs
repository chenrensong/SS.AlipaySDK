using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodePagedataSendResponse.
    /// </summary>
    public class AlipayCommerceEducateTuitioncodePagedataSendResponse : AopResponse
    {
        /// <summary>
        /// 页面数据录入id
        /// </summary>
        [XmlElement("pagedata_id")]
        public string PagedataId { get; set; }
    }
}
