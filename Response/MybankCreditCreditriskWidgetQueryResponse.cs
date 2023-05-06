using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// MybankCreditCreditriskWidgetQueryResponse.
    /// </summary>
    public class MybankCreditCreditriskWidgetQueryResponse : AopResponse
    {
        /// <summary>
        /// widget json数据
        /// </summary>
        [XmlElement("widgetjson")]
        public string Widgetjson { get; set; }
    }
}
