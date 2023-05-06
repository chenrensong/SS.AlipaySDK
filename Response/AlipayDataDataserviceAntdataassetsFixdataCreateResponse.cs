using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsFixdataCreateResponse.
    /// </summary>
    public class AlipayDataDataserviceAntdataassetsFixdataCreateResponse : AopResponse
    {
        /// <summary>
        /// 补数据操作是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
