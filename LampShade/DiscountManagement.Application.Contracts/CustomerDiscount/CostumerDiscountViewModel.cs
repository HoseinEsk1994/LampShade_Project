﻿using System;

namespace DiscountManagement.Application.Contracts.CustomerDiscount
{
    public class CostumerDiscountViewModel
    {
        public long ProductId { get; set; }

        public int DiscountRate { get; set; }

        public DateTime StartDateGr { get; set; }

        public string StartDate { get; set; }

        public DateTime EndDateGr { get; set; }

        public string EndDate { get; set; }

        public string Reason { get; set; }

        public string Product { get; set; }

    }
}
