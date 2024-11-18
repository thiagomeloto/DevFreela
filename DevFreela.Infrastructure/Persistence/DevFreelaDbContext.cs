using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext(List<Project> projects, List<User> users, List<Skill> skills)
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto APSNET Core 1", "Minha descrição de Projeto 1", 1, 1, 10000),
                new Project("Meu projeto APSNET Core 2", "Minha descrição de Projeto 2", 1, 1, 20000),
                new Project("Meu projeto APSNET Core 3", "Minha descrição de Projeto 3", 1, 1, 30000),
            };

            Users = new List<User>
            {
                new User("Thiago Meloto", "thiagomeloto@gmail.com", new DateTime(1995, 05, 22)),
                new User("Roberto Silva", "robertosilva@gmail.com", new DateTime(1999, 08, 12)),
                new User("João Pedro Carvalho", "joaopedrocarvalho@mail.com", new DateTime(2000, 01, 10))
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("SQL"),
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
