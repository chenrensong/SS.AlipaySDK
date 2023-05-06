using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayInsSceneInshealthserviceprodItemoperationrecordQueryResponse.
    /// </summary>
    public class AlipayInsSceneInshealthserviceprodItemoperationrecordQueryResponse : AopResponse
    {
        /// <summary>
        /// 操作记录列表
        /// </summary>
        [XmlArray("record_list")]
        [XmlArrayItem("external_item_operation_record_query_d_t_o")]
        public List<ExternalItemOperationRecordQueryDTO> RecordList { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
