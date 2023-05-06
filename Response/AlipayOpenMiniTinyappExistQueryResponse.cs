using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenMiniTinyappExistQueryResponse.
    /// </summary>
    public class AlipayOpenMiniTinyappExistQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否是小程序开发者
        /// </summary>
        [XmlElement("exist_mini")]
        public string ExistMini { get; set; }
    }
}
