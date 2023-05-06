using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasPutplanModifyResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasPutplanModifyResponse : AopResponse
    {
        /// <summary>
        /// 活动编辑结果，true 表示成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
