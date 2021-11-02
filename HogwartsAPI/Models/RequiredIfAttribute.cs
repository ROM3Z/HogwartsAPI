using System;

namespace HogwartsAPI.Models
{
    internal class RequiredIfAttribute : Attribute
    {
        private string v1;
        private string v2;

        public RequiredIfAttribute(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}