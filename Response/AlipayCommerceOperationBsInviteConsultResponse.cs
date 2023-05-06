using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceOperationBsInviteConsultResponse.
    /// </summary>
    public class AlipayCommerceOperationBsInviteConsultResponse : AopResponse
    {
        /// <summary>
        /// 是否被邀约
        /// </summary>
        [XmlElement("invitable")]
        public bool Invitable { get; set; }
    }
}
