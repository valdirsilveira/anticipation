﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.Infrastructure;

namespace api.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20180729143509_RenameTableAnticipationItems")]
    partial class RenameTableAnticipationItems
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("api.Models.EntityModel.Anticipation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AnalyzeDate")
                        .HasColumnName("DataAnalise");

                    b.Property<bool?>("AnalyzeResult")
                        .HasColumnName("ResultadoAnalise");

                    b.Property<long>("AnticipationStatusId")
                        .HasColumnName("AntecipacaoStatusId");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DataAntecipacao")
                        .HasDefaultValueSql("getdate()");

                    b.Property<decimal>("RequestedAmount")
                        .HasColumnName("ValorSolicitado")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("TransferAmount")
                        .HasColumnName("ValorRepasse")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("AnticipationStatusId");

                    b.ToTable("antecipacoes");
                });

            modelBuilder.Entity("api.Models.EntityModel.AnticipationItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AnticipationId");

                    b.HasKey("Id");

                    b.HasIndex("AnticipationId");

                    b.ToTable("AnticipationItem");
                });

            modelBuilder.Entity("api.Models.EntityModel.AnticipationStatus", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnName("Descricao");

                    b.HasKey("Id");

                    b.ToTable("antecipacaostatus");
                });

            modelBuilder.Entity("api.Models.EntityModel.Transaction", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("AcquirerConfirmation")
                        .HasColumnName("ConfirmacaoAdquirente");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("DataTransacao")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("Installments")
                        .HasColumnName("parcelas");

                    b.Property<decimal>("TransactionAmount")
                        .HasColumnName("ValorTransacao")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal?>("TransferAmount")
                        .HasColumnName("ValorRepasse")
                        .HasColumnType("decimal(8,2)");

                    b.Property<DateTime?>("TransferDate")
                        .HasColumnName("DataRepasse");

                    b.HasKey("Id");

                    b.ToTable("transacoes");
                });

            modelBuilder.Entity("api.Models.EntityModel.Anticipation", b =>
                {
                    b.HasOne("api.Models.EntityModel.AnticipationStatus", "AnticipationStatus")
                        .WithMany()
                        .HasForeignKey("AnticipationStatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("api.Models.EntityModel.AnticipationItem", b =>
                {
                    b.HasOne("api.Models.EntityModel.Anticipation", "Anticipation")
                        .WithMany("AnticipationItems")
                        .HasForeignKey("AnticipationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
