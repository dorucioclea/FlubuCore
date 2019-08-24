
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

namespace FlubuCore.Tasks.Docker.Manifest
{
     public partial class DockerManifestPushTask : ExternalProcessTaskBase<int, DockerManifestPushTask>
     {
        private string _manifest_list;

        
        public DockerManifestPushTask(string manifest_list)
        {
            ExecutablePath = "docker";
            WithArgumentsKeyFromAttribute();
_manifest_list = manifest_list;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Allow push to an insecure registry
        /// </summary>
        [ArgKey("insecure")]
        public DockerManifestPushTask Insecure()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Remove the local manifest list after push
        /// </summary>
        [ArgKey("purge")]
        public DockerManifestPushTask Purge()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_manifest_list);

            return base.DoExecute(context);
        }

     }
}
