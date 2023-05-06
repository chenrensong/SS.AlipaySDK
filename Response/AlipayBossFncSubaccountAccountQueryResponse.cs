using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossFncSubaccountAccountQueryResponse.
    /// </summary>
    public class AlipayBossFncSubaccountAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询子户结果信息
        /// </summary>
        [XmlElement("result_set")]
        public SubAccountInfoDTO ResultSet { get; set; }
    }
}
