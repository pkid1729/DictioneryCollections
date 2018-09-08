using System;
using System.Collections.Generic;

namespace DictioneryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string,object> dt=new Dictionary<string,object>();
           dt.Add("C_ID",1001);
           dt.Add("C_Name","Pranav Kumar");
           dt.Add("Specialization","CSE");
           dt.Add("Phone",7358163322);
           dt.Add("EMail","pkid1729@gmail.com");
           dt.Add("Salary",50000);
           dt.Add("Location","Chennai");
           foreach(string key in dt.Keys)
           Console.WriteLine(key +":"+dt[key]);
           Console.ReadLine();

        }
    }
}
