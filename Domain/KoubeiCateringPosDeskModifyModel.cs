using System;
using System.Xml.Serialization;

namespace SS.AlipaySDK.Domain
{
    /// <summary>
    /// KoubeiCateringPosDeskModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDeskModifyModel : AopObject
    {
        /// <summary>
        /// 餐桌信息
        /// </summary>
        [XmlElement("pos_desk")]
        public DeskEntity PosDesk { get; set; }
    }
}
