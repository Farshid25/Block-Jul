using Julius.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheJulius.Model
{
    public class Patient : User
    {
        
       public Patient(  string name,  UserEnum role) : base(name, role) {
            
        }
        public override string ToString() {
            var x = this.GetType().ToString();
            return "name: " + Name + "Role :" + Role + "type: " + x;
        }
    }
}
