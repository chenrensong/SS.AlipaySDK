using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasPutplanQueryResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasPutplanQueryResponse : AopResponse
    {
        /// <summary>
        /// 投放计划详情对象
        /// </summary>
        [XmlElement("detail")]
        public ChannelPutPlanDetailDTO Detail { get; set; }
    }
}
