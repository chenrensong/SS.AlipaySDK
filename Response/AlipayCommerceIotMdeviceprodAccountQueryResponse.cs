using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodAccountQueryResponse.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用户pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
