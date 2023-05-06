using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusPredictbuslineRetryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusPredictbuslineRetryResponse : AopResponse
    {
        /// <summary>
        /// 预测任务提交返回
        /// </summary>
        [XmlElement("result")]
        public CloudbusRetryPredictItem Result { get; set; }
    }
}
