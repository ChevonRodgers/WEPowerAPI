using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class PrmCollectObis
    {
        public string Obis { get; set; }
        public decimal ClassId { get; set; }
        public string ClassName { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public decimal? Phase { get; set; }
        public decimal? GroupNo { get; set; }
        public decimal? SortNo { get; set; }
        public decimal? ReadRemotelyStatus { get; set; }
        public decimal? CollectPlanStatus { get; set; }
        public decimal? SettingRemotelyStatus { get; set; }
        public string Vld { get; set; }
        public string XmlRoot { get; set; }
    }
}
