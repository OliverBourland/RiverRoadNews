using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiverRoadNews.Models
{
    public class NewsEvents
    {
        private string s;
        private DateTime d;
        private DateTime today = DateTime.Now;

        public int NewsEventID { get; set; }
        public string Story
        {
            get { return s; }
            set
            {

                if (value == "")
                    throw new Exception("Can't post empty story.");
                else
                    s = value;
            }
        }

        public string Title { get; set; }

        public DateTime Date
        {
            get { return d; }

            set
                {
                
                if (DateTime.Compare(value,today) == -1 || DateTime.Compare(value,today) == 0)
                    d = value;
                else throw new Exception ("Can not set to future date.");
                }
        }
        
    }
 
}
