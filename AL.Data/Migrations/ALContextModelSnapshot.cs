﻿// <auto-generated />
using AL.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AL.Data.Migrations
{
    [DbContext(typeof(ALContext))]
    partial class ALContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AL.Core.Domain.Conta", b =>
                {
                    b.Property<int>("ContaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContaID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("ContaID");

                    b.ToTable("Contas");
                });

            modelBuilder.Entity("AL.Core.Domain.PerfilConta", b =>
                {
                    b.Property<int>("PerfilContaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PerfilContaID"));

                    b.Property<int>("ContaID")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("PerfilContaID");

                    b.HasIndex("ContaID");

                    b.ToTable("PerfilContas");
                });

            modelBuilder.Entity("AL.Core.Domain.PerfilConta", b =>
                {
                    b.HasOne("AL.Core.Domain.Conta", "Conta")
                        .WithMany("PerfilContas")
                        .HasForeignKey("ContaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conta");
                });

            modelBuilder.Entity("AL.Core.Domain.Conta", b =>
                {
                    b.Navigation("PerfilContas");
                });
#pragma warning restore 612, 618
        }
    }
}
