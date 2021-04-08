﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Techchef_2.Models
{
    //public class Users
    //{
    //    public int Id { get; set; }
    //    public string Email { get; set; }
    //    public string Firstname { get; set; }
    //    public string Lastname { get; set; }
    //    public byte[] Avatar { get; set; }
    //}


      public class Datum
    {
        public int id { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string avatar { get; set; }
    }

    public class Support
    {
        public string url { get; set; }
        public string text { get; set; }
    }

    public class Root
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public Datum data { get; set; }
        public Support support { get; set; }
    }

}