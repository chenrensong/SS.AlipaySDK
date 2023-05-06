using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwTreeBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmSwTreeBatchqueryModel : AopObject
    {
        /// <summary>
        /// 子部门ID，不传为默认部门
        /// </summary>
        [XmlElement("ccs_instance_id")]
        public string CcsInstanceId { get; set; }
    }
}
