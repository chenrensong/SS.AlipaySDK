using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataDataserviceChinaremodelQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceChinaremodelQueryResponse : AopResponse
    {
        /// <summary>
        /// 中再核保模型查询结果
        /// </summary>
        [XmlElement("result")]
        public AlipayChinareModelResult Result { get; set; }
    }
}
