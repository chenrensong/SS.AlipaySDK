using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenXwbtesttomsgapiSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenXwbtesttomsgapiSyncModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("xwb")]
        public string Xwb { get; set; }
    }
}
