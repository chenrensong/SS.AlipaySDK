using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAppApiFieldQueryResponse.
    /// </summary>
    public class AlipayOpenAppApiFieldQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户信息申请信息记录查询响应模型
        /// </summary>
        [XmlElement("auth_field_response")]
        public AuthFieldResponse AuthFieldResponse { get; set; }
    }
}
