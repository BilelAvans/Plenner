﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Xml.Serialization;

namespace DataLab.Data.Planning
{
    public interface TimeSpanPlanning
    {

        DateTime Start { get; set;  }

        DateTime End { get; set; }
                
    }
}
