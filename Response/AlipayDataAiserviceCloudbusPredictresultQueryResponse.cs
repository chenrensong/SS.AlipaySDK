using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusPredictresultQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusPredictresultQueryResponse : AopResponse
    {
        /// <summary>
        /// 预测线路结果
        /// </summary>
        [XmlElement("result")]
        public CloudbusPredictResult Result { get; set; }
    }
}
