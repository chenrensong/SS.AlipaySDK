using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayAccountInstfundAccountSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountInstfundAccountSyncModel : AopObject
    {
        /// <summary>
        /// 账号信息
        /// </summary>
        [XmlElement("inst_account")]
        public InstAccountDTO InstAccount { get; set; }
    }
}
