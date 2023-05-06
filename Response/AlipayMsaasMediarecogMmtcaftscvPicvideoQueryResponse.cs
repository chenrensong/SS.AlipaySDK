using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvPicvideoQueryResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvPicvideoQueryResponse : AopResponse
    {
        /// <summary>
        /// 货柜每层视频展示信息
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 结果状态
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 交易ID
        /// </summary>
        [XmlElement("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 请求类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
