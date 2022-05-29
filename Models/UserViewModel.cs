using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserListWithPagination.Models
{
    public class APIData
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public string total { get; set; }
        public string total_pages { get; set; }
        public List<UserData> data { get; set; }
    }
    public class UserData
    {
        public string id { get; set; }
        [Display(Name = "First Name")]
        public string first_name { get; set; }
        [Display(Name = "Last Name")]
        public string last_name { get; set; }
        [Display(Name = "Email Address")]
        public string email { get; set; }
        [Display(Name = "Image")]
       public string avatar { get; set; }
    }
}