using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossFncSubaccountAccountApplyResponse.
    /// </summary>
    public class AlipayBossFncSubaccountAccountApplyResponse : AopResponse
    {
        /// <summary>
        /// 申请子户结果
        /// </summary>
        [XmlElement("result_set")]
        public ApplySubAccountAndBindResultDTO ResultSet { get; set; }
    }
}
