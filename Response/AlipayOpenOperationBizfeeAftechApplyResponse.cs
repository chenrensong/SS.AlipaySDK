using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenOperationBizfeeAftechApplyResponse.
    /// </summary>
    public class AlipayOpenOperationBizfeeAftechApplyResponse : AopResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [XmlElement("result_message")]
        public string ResultMessage { get; set; }
    }
}
