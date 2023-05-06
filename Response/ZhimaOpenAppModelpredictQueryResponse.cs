using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// ZhimaOpenAppModelpredictQueryResponse.
    /// </summary>
    public class ZhimaOpenAppModelpredictQueryResponse : AopResponse
    {
        /// <summary>
        /// 模型预测的结果
        /// </summary>
        [XmlElement("resp")]
        public string Resp { get; set; }
    }
}
