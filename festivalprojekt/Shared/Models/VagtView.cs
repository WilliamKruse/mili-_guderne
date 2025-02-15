﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace festivalprojekt.Shared.Models
{
    public class VagtView
    {
        public int VagtId { get; set; }
        public int VagtTypeId { get; set; }
        public DateTime StartTid { get; set; }
        public DateTime SlutTid { get; set; }
        public int? PersonId { get; set; }
        public string VagtTypeNavn { get; set; }
        public string VagtTypeBeskrivelse { get; set; }
        public string VagtTypeOmråde { get; set; }

        public override string ToString()
        {
            string status = "Taget";
            if (PersonId == null)
            {
                status = "ledig";
            }
            return $" Start: d.{StartTid:dd MMMM H:mm} Slut d.{SlutTid:dd MMMM H:mm}, Område: {VagtTypeOmråde} Status: {status}";
        }
    }
}

