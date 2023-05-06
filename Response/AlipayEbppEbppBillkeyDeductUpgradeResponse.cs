using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppEbppBillkeyDeductUpgradeResponse.
    /// </summary>
    public class AlipayEbppEbppBillkeyDeductUpgradeResponse : AopResponse
    {
        /// <summary>
        /// 提交成功or失败
        /// </summary>
        [XmlElement("submit_res")]
        public bool SubmitRes { get; set; }
    }
}
