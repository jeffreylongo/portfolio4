using portfolio4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace portfolio4.DataContext
{
    public class ProjectContext :DbContext
    {
        public ProjectContext():base("name=DefaultConnection")
        {

        }

        public DbSet<Project> Projects { get; set; }
    }
}