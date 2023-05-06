using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayPcreditUserOpencoremodeltestXinghuiModifyResponse.
    /// </summary>
    public class AlipayPcreditUserOpencoremodeltestXinghuiModifyResponse : AopResponse
    {
        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("c")]
        public string C { get; set; }
    }
}
