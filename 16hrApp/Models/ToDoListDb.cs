using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _16hrApp.Models
{
    public class ToDoListDb : DbContext
    {
        public ToDoListDb() : base("name=DefaultConnection")
        {

        }

        public DbSet<Day> Days { get; set; }
        public DbSet<ToDoListItem> ToDoListItems { get; set; }
    }
}