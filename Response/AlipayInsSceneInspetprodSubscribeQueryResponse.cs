using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsSceneInspetprodSubscribeQueryResponse.
    /// </summary>
    public class AlipayInsSceneInspetprodSubscribeQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否订阅公众号
        /// </summary>
        [XmlElement("subscribe")]
        public bool Subscribe { get; set; }
    }
}
