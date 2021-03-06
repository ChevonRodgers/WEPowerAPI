﻿using System;
using System.Collections.Generic;

namespace SmartLoadManagement.Models
{
    public partial class LogMeterTou
    {
        public decimal Id { get; set; }
        public decimal? TrfIndId { get; set; }
        public decimal? TrfTblId { get; set; }
        public decimal? TmlId { get; set; }
        public decimal? MeterId { get; set; }
        public DateTime? BeginDate { get; set; }
        public decimal? Result { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? Mdfon { get; set; }
        public decimal? Mdfby { get; set; }
    }
}
