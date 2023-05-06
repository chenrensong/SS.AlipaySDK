using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossFncGfaccruedprodCumpoaccbalamtQueryResponse.
    /// </summary>
    public class AlipayBossFncGfaccruedprodCumpoaccbalamtQueryResponse : AopResponse
    {
        /// <summary>
        /// po的累计余额信息
        /// </summary>
        [XmlElement("result_data")]
        public PoCumAccruedBalanceAmtDTO ResultData { get; set; }
    }
}
