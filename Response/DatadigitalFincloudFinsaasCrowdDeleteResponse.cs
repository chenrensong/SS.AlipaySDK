using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasCrowdDeleteResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasCrowdDeleteResponse : AopResponse
    {
        /// <summary>
        /// 人群删除消息+不唯一+删除人群
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }
    }
}
