using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasDesignPageOfflineResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasDesignPageOfflineResponse : AopResponse
    {
        /// <summary>
        /// 页面code
        /// </summary>
        [XmlElement("page_code")]
        public string PageCode { get; set; }
    }
}
