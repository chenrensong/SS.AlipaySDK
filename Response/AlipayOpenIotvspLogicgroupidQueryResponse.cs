using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayOpenIotvspLogicgroupidQueryResponse.
    /// </summary>
    public class AlipayOpenIotvspLogicgroupidQueryResponse : AopResponse
    {
        /// <summary>
        /// 开发场景的机构用户库id
        /// </summary>
        [XmlElement("logic_group_id")]
        public string LogicGroupId { get; set; }
    }
}
