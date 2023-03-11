using BigSchool_ThucHanh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool_ThucHanh.ViewModel
{
    public class CourseViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        
        public string Time { get; set; }
        public byte Categoery { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}