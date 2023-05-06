using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipaySocialAntfarmProjectinfoQueryResponse.
    /// </summary>
    public class AlipaySocialAntfarmProjectinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 正在进行的项目，含当前正在进行的标的物
        /// </summary>
        [XmlArray("project_list")]
        [XmlArrayItem("antfarm_project_info")]
        public List<AntfarmProjectInfo> ProjectList { get; set; }
    }
}
