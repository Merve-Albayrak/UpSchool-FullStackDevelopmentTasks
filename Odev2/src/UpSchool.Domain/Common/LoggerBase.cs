﻿


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpSchool.Domain.Common
{
    public abstract class LoggerBase //abstract classtan nesne türetilemez
    {
        public virtual void Log(string message)
        {

            Console.WriteLine(message);
        }
    }
}
