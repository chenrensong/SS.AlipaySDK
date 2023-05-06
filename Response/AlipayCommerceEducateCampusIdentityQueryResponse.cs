using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceEducateCampusIdentityQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCampusIdentityQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询用户是否目前是大学生
        /// </summary>
        [XmlElement("college_online_tag")]
        public string CollegeOnlineTag { get; set; }
    }
}
