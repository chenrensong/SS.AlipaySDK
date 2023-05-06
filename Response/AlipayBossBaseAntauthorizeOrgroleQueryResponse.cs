using System;
using System.Xml.Serialization;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayBossBaseAntauthorizeOrgroleQueryResponse.
    /// </summary>
    public class AlipayBossBaseAntauthorizeOrgroleQueryResponse : AopResponse
    {
        /// <summary>
        /// 组织节点上人员信息
        /// </summary>
        [XmlElement("org_role")]
        public OrgRoleDTO OrgRole { get; set; }
    }
}
