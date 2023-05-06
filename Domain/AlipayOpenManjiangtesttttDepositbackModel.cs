using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenManjiangtesttttDepositbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenManjiangtesttttDepositbackModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("sss")]
        public string Sss { get; set; }
    }
}
