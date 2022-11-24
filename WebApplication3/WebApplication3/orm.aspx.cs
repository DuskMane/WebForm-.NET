using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class orm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var context = new SchoolDBEntities())
            {
                //Grades grd = new Grades();
                //grd.GradeName = "1. Sınıf";
                //grd.Section = "Computer Science";
                //context.Grades.Add(grd);
                //context.SaveChanges();

                var grades = context.Grades.ToList();

                foreach(var item in grades)
                {
                    Response.Write($"Name:{item.GradeName} Section {item.Section}");
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (var context = new SchoolDBEntities())
            {
                var ogr = new Students();
                ogr.DateOfBirth = new DateTime(1999, 12, 11);
                ogr.Height = (decimal)182.5;
                ogr.Weight = (float)88.8;
                ogr.StudentName = "Emirhan Aykan";
                ogr.GradeId = 1;
                context.Students.Add(ogr);
                context.SaveChanges();
            }
        }
    }
}