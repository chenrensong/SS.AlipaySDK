using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// ViewColumnInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class ViewColumnInfoModel : AopObject
    {
        /// <summary>
        /// LEVEL：等级   TELEPHONE：联系方式   自定义栏位：行为由商户定义，自定义Code码（只要无重复）
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("column_more_info")]
        public ColumnMoreInfoModel ColumnMoreInfo { get; set; }

        /// <summary>
        /// 1、openNative：打开二级页面，展现 more中descs 。column_more_info不能为空，且column_more_info的descs不能为空。  2、openWeb：打开URL 。column_more_info不能为空，且column_more_info的url不能为空。  3、staticinfo：静态信息 。不能设置column_more_info  注意：   不填则默认staticinfo；   标准code尽量使用staticinfo，例如TELEPHONE商家电话栏位就只支持staticinfo；
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 栏目的标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 卡包详情页面，卡栏位右边展现的值   TELEPHONE栏位的商家联系电话号码由此value字段传入
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
