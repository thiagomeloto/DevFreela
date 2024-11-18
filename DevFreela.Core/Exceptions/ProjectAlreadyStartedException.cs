﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Exceptions
{
    class ProjectAlreadyStartedException : Exception
    {
        public ProjectAlreadyStartedException () : base("Project is already Started status")
        {

        }
    }
}
