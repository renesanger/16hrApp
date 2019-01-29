using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _16hrApp.Models
{
    public class Day
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ToDoListItem> Items { get; set; }
    }
}