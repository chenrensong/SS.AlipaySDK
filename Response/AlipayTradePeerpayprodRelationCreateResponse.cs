using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayTradePeerpayprodRelationCreateResponse.
    /// </summary>
    public class AlipayTradePeerpayprodRelationCreateResponse : AopResponse
    {
        /// <summary>
        /// 亲情号关系是否添加成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
