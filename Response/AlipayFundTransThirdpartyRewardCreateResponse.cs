using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayFundTransThirdpartyRewardCreateResponse.
    /// </summary>
    public class AlipayFundTransThirdpartyRewardCreateResponse : AopResponse
    {
        /// <summary>
        /// 打赏单据号
        /// </summary>
        [XmlElement("transfer_no")]
        public string TransferNo { get; set; }
    }
}
