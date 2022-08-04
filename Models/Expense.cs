using System;
using System.Collections.Generic;

namespace api2.Models
{
    public partial class Expense
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime? DateRegister { get; set; }
        public decimal? Amount { get; set; }
        public string? Tags { get; set; }
    }
}
