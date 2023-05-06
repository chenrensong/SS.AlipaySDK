using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataIotdataImageaestheticBaiQueryResponse.
    /// </summary>
    public class AlipayDataIotdataImageaestheticBaiQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回图片URL、打分结果和错误信息
        /// </summary>
        [XmlElement("data")]
        public AestheticData Data { get; set; }
    }
}
