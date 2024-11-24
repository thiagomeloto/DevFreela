using System;

namespace DevFreela.Core.Entities
{
    public class ProjectComment : BaseEntity
    {
        public ProjectComment(string comment, int idProject, int idUser)
        {
            Comment = comment;
            IdProject = idProject;
            IdUser = idUser;
        }

        public string Comment { get; private set; }
        public int IdProject { get; private set; }
        public GetProjectCommand Project { get; private set; }
        public int IdUser { get; private set; }
        public User User { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
