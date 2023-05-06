using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// ZhimaCustomerLiferecordSendResponse.
    /// </summary>
    public class ZhimaCustomerLiferecordSendResponse : AopResponse
    {
        /// <summary>
        /// 数据回流是否成功
        /// </summary>
        [XmlElement("feed_back_success")]
        public bool FeedBackSuccess { get; set; }

        /// <summary>
        /// 结果code
        /// </summary>
        [XmlElement("sub_code")]
        public string SubCode { get; set; }

        /// <summary>
        /// code对应的数值码
        /// </summary>
        [XmlElement("sub_code_number")]
        public long SubCodeNumber { get; set; }

        /// <summary>
        /// 异常码说明
        /// </summary>
        [XmlElement("sub_message")]
        public string SubMessage { get; set; }

        /// <summary>
        /// 接口调用是否成功
        /// </summary>
        [XmlElement("sub_success")]
        public bool SubSuccess { get; set; }
    }
}
