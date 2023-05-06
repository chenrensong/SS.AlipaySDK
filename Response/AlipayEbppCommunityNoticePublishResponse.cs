using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppCommunityNoticePublishResponse.
    /// </summary>
    public class AlipayEbppCommunityNoticePublishResponse : AopResponse
    {
        /// <summary>
        /// 公告id
        /// </summary>
        [XmlElement("alipay_notice_id")]
        public long AlipayNoticeId { get; set; }
    }
}
