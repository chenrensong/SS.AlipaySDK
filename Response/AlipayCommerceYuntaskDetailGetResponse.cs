using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskDetailGetResponse.
    /// </summary>
    public class AlipayCommerceYuntaskDetailGetResponse : AopResponse
    {
        /// <summary>
        /// 任务详情
        /// </summary>
        [XmlElement("task")]
        public YunTaskTemplateInfoDTO Task { get; set; }
    }
}
