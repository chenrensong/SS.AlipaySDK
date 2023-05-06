using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenAppSystemOldcontextTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppSystemOldcontextTransferModel : AopObject
    {
        /// <summary>
        /// 10
        /// </summary>
        [XmlElement("param_one")]
        public string ParamOne { get; set; }
    }
}
