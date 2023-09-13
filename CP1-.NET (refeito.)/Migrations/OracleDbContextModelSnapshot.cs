﻿// <auto-generated />
using System;
using CP1_.NET__refeito._.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace CP1_.NET__refeito._.Migrations
{
    [DbContext(typeof(OracleDbContext))]
    partial class OracleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CP1_.NET__refeito._.Models.Hospede", b =>
                {
                    b.Property<int>("HospedeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HospedeID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("HospedeID");

                    b.ToTable("Hospedes");
                });

            modelBuilder.Entity("CP1_.NET__refeito._.Models.Pagamento", b =>
                {
                    b.Property<int>("PagamentoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PagamentoID"));

                    b.Property<DateTime>("DataPagamento")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<decimal>("DataPagamentoName")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<int>("ReservaID")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("PagamentoID");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("CP1_.NET__refeito._.Models.Quarto", b =>
                {
                    b.Property<int>("QuartoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuartoID"));

                    b.Property<string>("NumeroQuarto")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<decimal>("PrecoPorNoite")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<int>("TipoQuartoID")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("QuartoID");

                    b.ToTable("Quartos");
                });

            modelBuilder.Entity("CP1_.NET__refeito._.Models.Reserva", b =>
                {
                    b.Property<int>("ReservaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservaID"));

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("DataSaida")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("HospedeID")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("QuartoID")
                        .HasColumnType("NUMBER(10)");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.HasKey("ReservaID");

                    b.HasIndex("HospedeID")
                        .IsUnique();

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("CP1_.NET__refeito._.Models.TipoQuarto", b =>
                {
                    b.Property<int>("TipoQuartoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoQuartoID"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("TipoQuartoID");

                    b.ToTable("TipoQuartos");
                });

            modelBuilder.Entity("CP1_.NET__refeito._.Models.Reserva", b =>
                {
                    b.HasOne("CP1_.NET__refeito._.Models.Hospede", "Hospede")
                        .WithOne("Reserva")
                        .HasForeignKey("CP1_.NET__refeito._.Models.Reserva", "HospedeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hospede");
                });

            modelBuilder.Entity("CP1_.NET__refeito._.Models.Hospede", b =>
                {
                    b.Navigation("Reserva")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
