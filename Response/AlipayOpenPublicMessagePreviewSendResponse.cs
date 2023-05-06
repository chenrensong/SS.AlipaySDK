using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenPublicMessagePreviewSendResponse.
    /// </summary>
    public class AlipayOpenPublicMessagePreviewSendResponse : AopResponse
    {
        /// <summary>
        /// 消息发送错误数据
        /// </summary>
        [XmlArray("error_datas")]
        [XmlArrayItem("msg_send_error_data")]
        public List<MsgSendErrorData> ErrorDatas { get; set; }
    }
}
