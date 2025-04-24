using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalExpenseTracker.Models
{
    public class Expense
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Column(TypeName = "REAL"),  Range(0.01, double.MaxValue)]
        public decimal Amount { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
