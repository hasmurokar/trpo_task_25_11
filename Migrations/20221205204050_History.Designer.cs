// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using trpo_task_25_11;

#nullable disable

namespace trpo_task_25_11.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20221205204050_History")]
    partial class History
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("trpo_task_25_11.Entrant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Biology")
                        .HasColumnType("int");

                    b.Property<int>("Chemistry")
                        .HasColumnType("int");

                    b.Property<int>("ForeignLang")
                        .HasColumnType("int");

                    b.Property<int>("Informatics")
                        .HasColumnType("int");

                    b.Property<int>("Math")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PE")
                        .HasColumnType("int");

                    b.Property<int>("Physics")
                        .HasColumnType("int");

                    b.Property<int>("RusLang")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Entrants");
                });

            modelBuilder.Entity("trpo_task_25_11.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("AvgNote")
                        .HasColumnType("float");

                    b.Property<int>("EntrantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Histories");
                });
#pragma warning restore 612, 618
        }
    }
}
