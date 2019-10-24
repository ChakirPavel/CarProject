using SQLite.Net.Attributes;
using System;

namespace CarProject.Models
{
    [System.AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class TitleField : System.Attribute
    {
        public string title;

        public TitleField(string title)
        {
            this.title = title;
        }
    }   
}
