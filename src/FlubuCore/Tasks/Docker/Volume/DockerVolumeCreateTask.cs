
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

namespace FlubuCore.Tasks.Docker.Volume
{
     public partial class DockerVolumeCreateTask : ExternalProcessTaskBase<int, DockerVolumeCreateTask>
     {
        private string _volume;

        
        public DockerVolumeCreateTask(string volume)
        {
            ExecutablePath = "docker";
            WithArgumentsKeyFromAttribute();
_volume = volume;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Specify volume driver name
        /// </summary>
        [ArgKey("driver")]
        public DockerVolumeCreateTask Driver(string driver)
        {
            WithArgumentsKeyFromAttribute(driver.ToString());
            return this;
        }

        /// <summary>
        /// Set metadata for a volume
        /// </summary>
        [ArgKey("label")]
        public DockerVolumeCreateTask Label(string label)
        {
            WithArgumentsKeyFromAttribute(label.ToString());
            return this;
        }

        /// <summary>
        /// Specify volume name
        /// </summary>
        [ArgKey("name")]
        public DockerVolumeCreateTask Name(string name)
        {
            WithArgumentsKeyFromAttribute(name.ToString());
            return this;
        }

        /// <summary>
        /// Set driver specific options
        /// </summary>
        [ArgKey("opt")]
        public DockerVolumeCreateTask Opt(string opt)
        {
            WithArgumentsKeyFromAttribute(opt.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_volume);

            return base.DoExecute(context);
        }

     }
}
