using System;

namespace DevFreela.Core.Exceptions
{
    class ProjectAlreadyStartedException : Exception
    {
        public ProjectAlreadyStartedException () : base("Project is already Started status")
        {

        }
    }
}
