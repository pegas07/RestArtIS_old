﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestArtIS.Server.Data;

namespace RestArtIS.Server.Migrations
{
    [DbContext(typeof(RestArtISContext))]
    partial class RestArtISContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RestArtIS.Server.Models.Company", b =>
                {
                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("CompanyId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("RestArtIS.Server.Models.ItemPrice", b =>
                {
                    b.Property<Guid>("ItemPriceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("ValidFrom")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("ValidTo")
                        .HasColumnType("datetime");

                    b.Property<decimal?>("Value")
                        .HasColumnType("money");

                    b.Property<Guid?>("VatVid")
                        .HasColumnName("VatVId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ItemPriceId");

                    b.ToTable("ItemPrice");
                });

            modelBuilder.Entity("RestArtIS.Server.Models.Menu", b =>
                {
                    b.Property<Guid>("MenuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateFrom")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateTo")
                        .HasColumnType("date");

                    b.Property<short>("MenuType")
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<Guid?>("ParlorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("VisibleFrom")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("VisibleTo")
                        .HasColumnType("datetime");

                    b.HasKey("MenuId");

                    b.HasIndex("ParlorId");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("RestArtIS.Server.Models.Parlor", b =>
                {
                    b.Property<Guid>("ParlorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("ParlorId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Parlor");
                });

            modelBuilder.Entity("RestArtIS.Server.Models.PriceCategory", b =>
                {
                    b.Property<Guid>("PriceCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("PriceCategoryId");

                    b.ToTable("PriceCategory");
                });

            modelBuilder.Entity("RestArtIS.Server.Models.RestArtItem", b =>
                {
                    b.Property<Guid>("RestArtItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Alergens")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Descrip")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<Guid?>("ItemCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("RestArtItemId");

                    b.HasIndex("ItemCategoryId");

                    b.ToTable("RestArtItem");
                });

            modelBuilder.Entity("RestArtIS.Server.Models.RestArtItemCategory", b =>
                {
                    b.Property<Guid>("RestArtItemCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("RestArtItemCategoryId");

                    b.ToTable("RestArtItemCategory");
                });

            modelBuilder.Entity("RestArtIS.Server.Models.Vat", b =>
                {
                    b.Property<Guid>("VatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(4, 2)");

                    b.Property<DateTime>("ValidFrom")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("ValidTo")
                        .HasColumnType("datetime");

                    b.Property<Guid?>("ValueId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("VatId");

                    b.ToTable("Vat");
                });

            modelBuilder.Entity("RestArtIS.Server.Models.Menu", b =>
                {
                    b.HasOne("RestArtIS.Server.Models.Parlor", "Parlor")
                        .WithMany("Menu")
                        .HasForeignKey("ParlorId")
                        .HasConstraintName("FK_Menu_Parlor");
                });

            modelBuilder.Entity("RestArtIS.Server.Models.Parlor", b =>
                {
                    b.HasOne("RestArtIS.Server.Models.Company", "Company")
                        .WithMany("Parlor")
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("FK_Parlor_Company");
                });

            modelBuilder.Entity("RestArtIS.Server.Models.RestArtItem", b =>
                {
                    b.HasOne("RestArtIS.Server.Models.RestArtItemCategory", "ItemCategory")
                        .WithMany("RestArtItem")
                        .HasForeignKey("ItemCategoryId")
                        .HasConstraintName("FK_RestArtItem_RestArtItemCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
