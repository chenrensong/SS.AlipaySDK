using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwLibraryDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmSwLibraryDeleteModel : AopObject
    {
        /// <summary>
        /// 子部门ID，不传为默认部门
        /// </summary>
        [XmlElement("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 知识库ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
