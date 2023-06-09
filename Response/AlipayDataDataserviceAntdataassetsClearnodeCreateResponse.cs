using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsClearnodeCreateResponse.
    /// </summary>
    public class AlipayDataDataserviceAntdataassetsClearnodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 清除任务操作是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
