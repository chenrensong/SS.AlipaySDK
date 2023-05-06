using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditmerchantProductorderidApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiPcreditmerchantProductorderidApplyModel : AopObject
    {
        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
