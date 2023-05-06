using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceOperationPromoterTaskReceiveResponse.
    /// </summary>
    public class AlipayCommerceOperationPromoterTaskReceiveResponse : AopResponse
    {
        /// <summary>
        /// 积分领取结果
        /// </summary>
        [XmlElement("task_receive_result")]
        public TaskReceiveInfo TaskReceiveResult { get; set; }
    }
}
