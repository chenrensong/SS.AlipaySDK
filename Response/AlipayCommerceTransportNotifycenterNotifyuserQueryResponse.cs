using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceTransportNotifycenterNotifyuserQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportNotifycenterNotifyuserQueryResponse : AopResponse
    {
        /// <summary>
        /// 订阅用户vo列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("notify_user_vo")]
        public List<NotifyUserVo> Result { get; set; }
    }
}
