﻿// <auto-generated />
using System;
using MSDF.StudentEngagement.Persistence.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MSDF.StudentEngagement.Persistence.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("MSDF.StudentEngagement.Persistence.Models.LearningApp", b =>
                {
                    b.Property<string>("LearningAppIdentifier")
                        .HasColumnType("character varying(60)")
                        .HasMaxLength(60);

                    b.Property<string>("AppUrl")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Description")
                        .HasColumnType("character varying(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("Namespace")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Website")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.HasKey("LearningAppIdentifier");

                    b.ToTable("LearningApp");
                });

            modelBuilder.Entity("MSDF.StudentEngagement.Persistence.Models.StudentInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("BirthSexDescriptorCodeValue")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ContactInfoCellPhoneNumber")
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<string>("ContactInfoElectronicMailAddress")
                        .HasColumnType("character varying(60)")
                        .HasMaxLength(60);

                    b.Property<string>("ContactInfoFirstName")
                        .HasColumnType("character varying(75)")
                        .HasMaxLength(75);

                    b.Property<string>("ContactInfoLastSurname")
                        .HasColumnType("character varying(75)")
                        .HasMaxLength(75);

                    b.Property<string>("ContactInfoRelationToStudent")
                        .HasColumnType("character varying(75)")
                        .HasMaxLength(75);

                    b.Property<string>("DeviceId")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("DisabilityStatusDescriptorCodeValue")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ELLStatusDescriptorCodeValue")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("EconomicallyDisadvantageDescriptorCodeValue")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Ethnicity")
                        .HasColumnType("character varying(25)")
                        .HasMaxLength(25);

                    b.Property<DateTime?>("ExitWithdrawalDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("F504DescriptorCodeValue")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .HasColumnType("character varying(75)")
                        .HasMaxLength(75);

                    b.Property<string>("FosterDescriptorCodeValue")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("HomelessDescriptorCodeValue")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("IdentityElectronicMailAddress")
                        .HasColumnType("character varying(60)")
                        .HasMaxLength(60);

                    b.Property<string>("LastSurname")
                        .HasColumnType("character varying(75)")
                        .HasMaxLength(75);

                    b.Property<string>("LocalEducationAgencyName")
                        .HasColumnType("character varying(75)")
                        .HasMaxLength(75);

                    b.Property<string>("MiddleName")
                        .HasColumnType("character varying(75)")
                        .HasMaxLength(75);

                    b.Property<string>("MigrantDescriptorCodeValue")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<bool?>("Race_AmericanIndianAlaskanNative")
                        .HasColumnType("boolean");

                    b.Property<bool?>("Race_Asian")
                        .HasColumnType("boolean");

                    b.Property<bool?>("Race_BlackAfricaAmerican")
                        .HasColumnType("boolean");

                    b.Property<bool?>("Race_ChooseNotToRespond")
                        .HasColumnType("boolean");

                    b.Property<bool?>("Race_NativeHawaiianPacificIslander")
                        .HasColumnType("boolean");

                    b.Property<bool?>("Race_Other")
                        .HasColumnType("boolean");

                    b.Property<bool?>("Race_White")
                        .HasColumnType("boolean");

                    b.Property<string>("SchoolCurrentGradeLevelDescriptorCodeValue")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("SchoolName")
                        .HasColumnType("character varying(75)")
                        .HasMaxLength(75);

                    b.Property<string>("SchoolTypeDescriptorCodeValue")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("SchoolYear")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<string>("StudentStateIdentificationCode")
                        .HasColumnType("character varying(60)")
                        .HasMaxLength(60);

                    b.Property<int>("StudentUSI")
                        .HasColumnType("integer");

                    b.Property<string>("StudentUniqueId")
                        .HasColumnType("character varying(32)")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("StudentInformation");
                });

            modelBuilder.Entity("MSDF.StudentEngagement.Persistence.Models.StudentLearningEventLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DeviceId")
                        .HasColumnType("character varying(32)")
                        .HasMaxLength(32);

                    b.Property<string>("IPAddress")
                        .HasColumnType("character varying(15)")
                        .HasMaxLength(15);

                    b.Property<string>("LeaningAppUrl")
                        .HasColumnType("character varying(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("ReffererUrl")
                        .HasColumnType("character varying(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("StudentElectronicMailAddress")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<int>("StudentUSI")
                        .HasColumnType("integer");

                    b.Property<string>("StudentUniqueId")
                        .HasColumnType("character varying(32)")
                        .HasMaxLength(32);

                    b.Property<int?>("TimeSpent")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UTCEndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("UTCStartDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("StudentLearningEventLog");
                });
#pragma warning restore 612, 618
        }
    }
}
