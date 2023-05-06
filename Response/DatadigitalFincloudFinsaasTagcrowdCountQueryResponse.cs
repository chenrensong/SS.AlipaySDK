using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasTagcrowdCountQueryResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasTagcrowdCountQueryResponse : AopResponse
    {
        /// <summary>
        /// 人群数量+不唯一
        /// </summary>
        [XmlElement("crowd_count")]
        public string CrowdCount { get; set; }
    }
}
