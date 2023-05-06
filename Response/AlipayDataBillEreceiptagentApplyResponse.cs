using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataBillEreceiptagentApplyResponse.
    /// </summary>
    public class AlipayDataBillEreceiptagentApplyResponse : AopResponse
    {
        /// <summary>
        /// 文件申请号file_id信息。使用file_id可以查询处理状态
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
