﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeamManagement.Context;

namespace TeamManagement.Migrations
{
    [DbContext(typeof(TeamManagementDbContext))]
    partial class TeamManagementDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TeamManagement.Models.BusinessUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BU_ID")
                        .UseIdentityColumn();

                    b.Property<bool>("Activity")
                        .HasColumnType("bit")
                        .HasColumnName("ACTIVITY");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("CHAR(500)")
                        .HasColumnName("BU_DESCRIPTION");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("CHAR(50)")
                        .HasColumnName("BU_NAME");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("CHAR(4)")
                        .HasColumnName("BU_TYPE");

                    b.HasKey("Id");

                    b.ToTable("BusinessUnit");
                });

            modelBuilder.Entity("TeamManagement.Models.BusinessUnitCategories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BUC_ID")
                        .UseIdentityColumn();

                    b.Property<int>("BusinessUnitId")
                        .HasColumnType("int")
                        .HasColumnName("BU_ID");

                    b.Property<string>("ZurichLineOfBusiness")
                        .IsRequired()
                        .HasColumnType("char(50)")
                        .HasColumnName("ZURICH_LINE_OF_BUSINESS");

                    b.HasKey("Id");

                    b.HasIndex("BusinessUnitId");

                    b.ToTable("BusinessUnitCategories");
                });

            modelBuilder.Entity("TeamManagement.Models.BusinessUnitMemebers", b =>
                {
                    b.Property<int>("BusinessUnitMemebersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BUM_ID")
                        .UseIdentityColumn();

                    b.Property<int>("BusinessUnitId")
                        .HasColumnType("int")
                        .HasColumnName("BU_ID");

                    b.Property<string>("EmployeeLoginId")
                        .IsRequired()
                        .HasColumnType("char(100)")
                        .HasColumnName("EMPLOYEE_LOGIN_ID");

                    b.Property<bool>("IsManager")
                        .HasColumnType("bit")
                        .HasColumnName("IS_MANAGER");

                    b.HasKey("BusinessUnitMemebersId");

                    b.HasIndex("BusinessUnitId");

                    b.ToTable("BusinessUnitMemebers");
                });

            modelBuilder.Entity("TeamManagement.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeLoginId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("EMP_LOGIN_ID");

                    b.Property<int>("BusinessUnitId")
                        .HasColumnType("int")
                        .HasColumnName("BU_ID");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("char(300)")
                        .HasColumnName("EMAIL_ADDRESS");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("char(50)")
                        .HasColumnName("FIRST_NAME");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("char(50)")
                        .HasColumnName("LAST_NAME");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("char(3)")
                        .HasColumnName("STATUS");

                    b.HasKey("EmployeeLoginId");

                    b.HasIndex("BusinessUnitId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("TeamManagement.Models.BusinessUnitCategories", b =>
                {
                    b.HasOne("TeamManagement.Models.BusinessUnit", "BusinessUnit")
                        .WithMany()
                        .HasForeignKey("BusinessUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BusinessUnit");
                });

            modelBuilder.Entity("TeamManagement.Models.BusinessUnitMemebers", b =>
                {
                    b.HasOne("TeamManagement.Models.BusinessUnit", "BusinessUnit")
                        .WithMany()
                        .HasForeignKey("BusinessUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BusinessUnit");
                });

            modelBuilder.Entity("TeamManagement.Models.Employee", b =>
                {
                    b.HasOne("TeamManagement.Models.BusinessUnit", "BusinessUnit")
                        .WithMany()
                        .HasForeignKey("BusinessUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BusinessUnit");
                });
#pragma warning restore 612, 618
        }
    }
}
