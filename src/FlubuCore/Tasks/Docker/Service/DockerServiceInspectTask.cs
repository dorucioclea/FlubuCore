
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Attributes;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Service
{
     public partial class DockerServiceInspectTask : ExternalProcessTaskBase<int, DockerServiceInspectTask>
     {
        private string[] _service;

        
        public DockerServiceInspectTask(params string[] service)
        {
            ExecutablePath = "docker";
            WithArgumentsKeyFromAttribute();
_service = service;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Format the output using the given Go template
        /// </summary>
        [ArgKey("format")]
        public DockerServiceInspectTask Format(string format)
        {
            WithArgumentsKeyFromAttribute(format.ToString());
            return this;
        }

        /// <summary>
        /// Print the information in a human friendly format
        /// </summary>
        [ArgKey("pretty")]
        public DockerServiceInspectTask Pretty()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_service);

            return base.DoExecute(context);
        }

     }
}
