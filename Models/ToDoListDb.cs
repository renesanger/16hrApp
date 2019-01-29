using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _16hr.Models
{
    public class ToDoListDb : DbContext
    {
        public DbSet<Day> Days { get; set; }
        public DbSet<ToDoListItem> ToDoListItems { get; set; }
    }

}