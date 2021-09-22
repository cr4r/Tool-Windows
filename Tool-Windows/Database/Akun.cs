using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Tool_Windows.Database
{
    class Akun
    {
        public string status { get; set; }
        public string result { get; set; }
        public IList<DataAkun> data;
    }

    public class DataAkun
    {
        public ObjectId Id { get; set; }
        public string username { get; set; }
        public string nama { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string nohp { get; set; }
    }
}
