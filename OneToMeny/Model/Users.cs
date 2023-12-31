﻿using Microsoft.Extensions.Hosting;
using System.Data;
using System.Text.Json.Serialization;

namespace OneToMeny.Model
{
    public class Users
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public DateTime DateTimeCreate {  get; set; }
        //[JsonIgnore]
        public List<Role> roles { get; set; } = new List<Role>();

    }

}
