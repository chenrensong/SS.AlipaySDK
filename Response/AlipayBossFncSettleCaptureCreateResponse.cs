using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossFncSettleCaptureCreateResponse.
    /// </summary>
    public class AlipayBossFncSettleCaptureCreateResponse : AopResponse
    {
        /// <summary>
        /// 请款创建数据对象
        /// </summary>
        [XmlArray("result_set")]
        [XmlArrayItem("capture_create_d_t_o")]
        public List<CaptureCreateDTO> ResultSet { get; set; }
    }
}
