using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieEditorGetResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieEditorGetResponse : AopResponse
    {
        /// <summary>
        /// 唤起云凤蝶站点编辑器返回模型，包含 编辑器具体免登的url
        /// </summary>
        [XmlElement("data")]
        public FengdieEditorGetRespModel Data { get; set; }
    }
}
