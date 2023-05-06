using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayAccountInstfundWithdrawApplyResponse.
    /// </summary>
    public class AlipayAccountInstfundWithdrawApplyResponse : AopResponse
    {
        /// <summary>
        /// 资金指令唯一标识
        /// </summary>
        [XmlElement("instruction_no")]
        public string InstructionNo { get; set; }
    }
}
