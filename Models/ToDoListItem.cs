using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _16hr.Models
{
    public class ToDoListItem
    {
        public int Id { get; set; }
        public string DateBegin { get; set; }
        public string DateEnd { get; set; }
        public string Message { get; set; }
    }
}