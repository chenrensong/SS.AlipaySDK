using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayBossFncGfcenterBanklogtransferCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfcenterBanklogtransferCreateModel : AopObject
    {
        /// <summary>
        /// 银行流水转账form
        /// </summary>
        [XmlElement("bank_log_transfer_form_new")]
        public BankLogTransferFormNew BankLogTransferFormNew { get; set; }
    }
}
