using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenAppOpenbizmockApisdkgrayQueryResponse.
    /// </summary>
    public class AlipayOpenAppOpenbizmockApisdkgrayQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试接口参数随便配置
        /// </summary>
        [XmlElement("output_param")]
        public string OutputParam { get; set; }
    }
}
