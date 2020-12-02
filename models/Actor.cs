using System;
using System.Collections.Generic;

namespace thatnewnew.models
{
    public class Actor
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName { get; set; }

        public void setFullName() {
            this.fullName = firstName + " " + lastName;
        }
    }
}