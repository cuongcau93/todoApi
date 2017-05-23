using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class TodoItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Key { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public bool isFullTime { get; set; }
        public string paymentType { get; set; }
        public string primaryLanguage { get; set; }
        public string dateHired { get; set; }
    }
}
