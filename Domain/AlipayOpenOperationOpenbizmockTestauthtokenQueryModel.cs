using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockTestauthtokenQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOperationOpenbizmockTestauthtokenQueryModel : AopObject
    {
        /// <summary>
        /// 测试专用
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }
    }
}
