using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayUserStepcounterDataBatchqueryResponse.
    /// </summary>
    public class AlipayUserStepcounterDataBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 查询到的用户日计步信息
        /// </summary>
        [XmlArray("step_info")]
        [XmlArrayItem("stepcounter_data_info")]
        public List<StepcounterDataInfo> StepInfo { get; set; }
    }
}
