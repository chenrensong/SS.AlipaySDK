using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// KoubeiCateringPosPrintQueryResponse.
    /// </summary>
    public class KoubeiCateringPosPrintQueryResponse : AopResponse
    {
        /// <summary>
        /// 打印机Model对象集合
        /// </summary>
        [XmlArray("print_model_list")]
        [XmlArrayItem("print_model")]
        public List<PrintModel> PrintModelList { get; set; }
    }
}
