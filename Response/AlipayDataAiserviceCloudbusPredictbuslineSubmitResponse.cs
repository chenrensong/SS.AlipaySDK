using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusPredictbuslineSubmitResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusPredictbuslineSubmitResponse : AopResponse
    {
        /// <summary>
        /// 预测任务提交返回
        /// </summary>
        [XmlElement("result")]
        public CloudbusSubmitPredictItem Result { get; set; }
    }
}
