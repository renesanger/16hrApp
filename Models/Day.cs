using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _16hr.Models
{
    public class Day
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ToDoListItem> Items { get; set; }
    }
}