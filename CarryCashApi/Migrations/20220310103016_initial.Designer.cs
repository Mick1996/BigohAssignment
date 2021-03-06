// <auto-generated />
using System;
using CarryCashApi.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarryCashApi.Migrations
{
    [DbContext(typeof(CarryCashDbContext))]
    [Migration("20220310103016_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarryCashApi.Model.Merchant", b =>
                {
                    b.Property<Guid>("Merchant_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Anually_Income")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Business_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorporateStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Created_By")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Excepted_amount_of_disbursment")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Registration_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type_of_business")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Updated_By")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Merchant_Id");

                    b.ToTable("merchant");
                });

            modelBuilder.Entity("CarryCashApi.Model.Owner", b =>
                {
                    b.Property<int>("Owner_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Owner_Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone_no")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Owner_Id");

                    b.ToTable("owner");
                });

            modelBuilder.Entity("CarryCashApi.Model.Payee", b =>
                {
                    b.Property<int>("Payee_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Payee_Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Created_By")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsKyb")
                        .HasColumnType("bit");

                    b.Property<bool>("IsKyc")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_Individual")
                        .HasColumnType("bit");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Payee_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Updated_By")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Payee_Id");

                    b.ToTable("payee");
                });

            modelBuilder.Entity("CarryCashApi.Model.Payee_Kyb", b =>
                {
                    b.Property<string>("Document_no")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Created_By")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Document_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Payee_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Updated_By")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Document_no");

                    b.ToTable("payee_kyb");
                });

            modelBuilder.Entity("CarryCashApi.Model.Payee_Kyc", b =>
                {
                    b.Property<string>("Document_no")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Created_By")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Document_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Payee_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Updated_By")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Document_no");

                    b.ToTable("payee_kyc");
                });

            modelBuilder.Entity("CarryCashApi.Model.Transaction", b =>
                {
                    b.Property<string>("Tranx_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Created_By")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Merchant_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Tranx_Amt")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Tranx_Date_Time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Updated_By")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Tranx_Id");

                    b.ToTable("transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
