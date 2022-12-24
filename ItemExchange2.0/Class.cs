using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ItemExchange2._0
{
    public class User : IEquatable<User>
    {
        public string name;
        public string address;
        public string phoneNumber;
        public string password;

        public User(string name,string password, string address="", string phoneNumber="") 
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.password = password;
        }

        //根据用户名和密码来判断两者是否相同
        public bool Equals(User other) 
        {
            if (other.name == this.name 
                && other.password == this.password)
                return true;
            else 
                return false;
        }
    }
   
    public class Tag : IEquatable<Tag>
    {
        public string name;
        public string property;

        public bool Equals(Tag other)
        {
            if (other.name == this.name)
                return true;
            else
                return false;
        }

    }

    public class Item : IEquatable<Item>
    {
        public string tag;
        public string name;
        public string property;
        public string address;
        public string ownerPhone;
        public string ownerEmail;

        public bool Equals(Item other)
        {
            if (other.name == this.name)
                return true;
            else
                return false;
        }
    }

}
