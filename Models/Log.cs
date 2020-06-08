using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityCoreTest2.Models
{
    public class Log
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Comment { get; set; }
        public DateTime EventDateTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}
