using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevFreela.Infrastructure.Persistence.Configurations
{
    public class ProjectConfigurations : IEntityTypeConfiguration<GetProjectCommand>
    {
        public void Configure(EntityTypeBuilder<GetProjectCommand> builder)
        {
            //Adicionando chave primária para tabela Project
            builder
                .HasKey(p => p.Id);

            //Adicionando chave estrangeira na tabela Project
            builder
                .HasOne(p => p.Freelancer)
                .WithMany(f => f.FreelanceProjects)
                .HasForeignKey(p => p.IdFreelancer)
                .OnDelete(DeleteBehavior.Restrict);

            //Adicionando chave estrangeira na tabela Project
            builder
                .HasOne(p => p.Client)
                .WithMany(f => f.OwnedProjects)
                .HasForeignKey(p => p.IdClient)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
