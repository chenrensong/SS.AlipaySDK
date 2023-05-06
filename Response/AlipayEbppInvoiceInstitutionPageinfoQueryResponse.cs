using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using SS.AlipaySDK.Domain;

namespace SS.AlipaySDK.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInstitutionPageinfoQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceInstitutionPageinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 制度基本信息列表
        /// </summary>
        [XmlArray("institution_basic_info_list")]
        [XmlArrayItem("institution_basic_info")]
        public List<InstitutionBasicInfo> InstitutionBasicInfoList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_page_count")]
        public long TotalPageCount { get; set; }
    }
}
