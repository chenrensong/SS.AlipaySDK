using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsUploadjobCreateResponse.
    /// </summary>
    public class AlipayDataDataserviceAntdataassetsUploadjobCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建上云任务之后生成的任务ID
        /// </summary>
        [XmlElement("uca_dataset_id")]
        public long UcaDatasetId { get; set; }
    }
}
