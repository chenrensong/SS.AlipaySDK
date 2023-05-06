using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAccountAliyunUnbindResponse.
    /// </summary>
    public class AlipayOpenAccountAliyunUnbindResponse : AopResponse
    {
        /// <summary>
        /// 解绑结果，true解绑成功，false解绑失败
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
