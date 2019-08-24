
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

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerCommitTask : ExternalProcessTaskBase<int, DockerCommitTask>
     {
        private string _container;
private string _repository;

        
        public DockerCommitTask(string container,  string repository)
        {
            ExecutablePath = "docker";
            WithArgumentsKeyFromAttribute();
_container = container;
_repository = repository;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Author (e.g., "John Hannibal Smith <hannibal@a-team.com>")
        /// </summary>
        [ArgKey("author")]
        public DockerCommitTask Author(string author)
        {
            WithArgumentsKeyFromAttribute(author.ToString());
            return this;
        }

        /// <summary>
        /// Apply Dockerfile instruction to the created image
        /// </summary>
        [ArgKey("change")]
        public DockerCommitTask Change(string change)
        {
            WithArgumentsKeyFromAttribute(change.ToString());
            return this;
        }

        /// <summary>
        /// Commit message
        /// </summary>
        [ArgKey("message")]
        public DockerCommitTask Message(string message)
        {
            WithArgumentsKeyFromAttribute(message.ToString());
            return this;
        }

        /// <summary>
        /// Pause container during commit
        /// </summary>
        [ArgKey("pause")]
        public DockerCommitTask Pause()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_container);
 WithArguments(_repository);

            return base.DoExecute(context);
        }

     }
}
