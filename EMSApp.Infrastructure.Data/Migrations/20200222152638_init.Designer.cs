﻿// <auto-generated />
using System;
using EMSApp.Infrastructure.Data.DbContextConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EMSApp.Infrastructure.Data.Migrations
{
    [DbContext(typeof(EMSHostDbContext))]
    [Migration("20200222152638_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("EMSApp.Core.Entities.Licence", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("LicenceType")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("ModifedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.ToTable("Licence");
                });

            modelBuilder.Entity("EMSApp.Core.Entities.Tenant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AppName")
                        .HasColumnType("text");

                    b.Property<string>("ConnectionString")
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Host")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("ModifedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<bool>("ResourcesCreated")
                        .HasColumnType("boolean");

                    b.Property<Guid>("TenantSettingId")
                        .HasColumnType("uuid");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.HasIndex("TenantSettingId");

                    b.ToTable("Tenant");
                });

            modelBuilder.Entity("EMSApp.Core.Entities.TenantContact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("ModifedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("TenantContact");
                });

            modelBuilder.Entity("EMSApp.Core.Entities.TenantContactToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("ModifedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<Guid>("TenantContactId")
                        .HasColumnType("uuid");

                    b.Property<bool>("Valid")
                        .HasColumnType("boolean");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.HasIndex("TenantContactId");

                    b.ToTable("TenantContactToken");
                });

            modelBuilder.Entity("EMSApp.Core.Entities.TenantLicence", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LicenceEndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("LicenceId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("LicenceStartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("ModifedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.HasIndex("LicenceId");

                    b.HasIndex("TenantId");

                    b.ToTable("TenantLicence");
                });

            modelBuilder.Entity("EMSApp.Core.Entities.TenantSetting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Currency")
                        .HasColumnType("text");

                    b.Property<string>("DatetimeZone")
                        .HasColumnType("text");

                    b.Property<string>("FloatingPointChar")
                        .HasColumnType("text");

                    b.Property<string>("Language")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ModifedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("ThousandSeperatorChar")
                        .HasColumnType("text");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.ToTable("TenantSetting");
                });

            modelBuilder.Entity("EMSApp.Core.Entities.Tenant", b =>
                {
                    b.HasOne("EMSApp.Core.Entities.TenantSetting", "TenantSetting")
                        .WithMany()
                        .HasForeignKey("TenantSettingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EMSApp.Core.Entities.TenantContact", b =>
                {
                    b.HasOne("EMSApp.Core.Entities.Tenant", "Tenant")
                        .WithMany("Responsibles")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EMSApp.Core.Entities.TenantContactToken", b =>
                {
                    b.HasOne("EMSApp.Core.Entities.TenantContact", "TenantContact")
                        .WithMany("Tokens")
                        .HasForeignKey("TenantContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EMSApp.Core.Entities.TenantLicence", b =>
                {
                    b.HasOne("EMSApp.Core.Entities.Licence", "Licence")
                        .WithMany()
                        .HasForeignKey("LicenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EMSApp.Core.Entities.Tenant", "Tenant")
                        .WithMany("Licences")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
