using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayOpenMessagetestCesSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMessagetestCesSendModel : AopObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlArray("cop")]
        [XmlArrayItem("gavintest_new_levea_one")]
        public List<GavintestNewLeveaOne> Cop { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        [XmlArray("str")]
        [XmlArrayItem("string")]
        public List<string> Str { get; set; }
    }
}
