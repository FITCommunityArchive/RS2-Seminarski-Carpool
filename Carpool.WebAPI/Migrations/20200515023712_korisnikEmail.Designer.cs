﻿// <auto-generated />
using System;
using Carpool.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Carpool.WebAPI.Migrations
{
    [DbContext(typeof(CarpoolContext))]
    [Migration("20200515023712_korisnikEmail")]
    partial class korisnikEmail
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Carpool.WebAPI.Database.Automobil", b =>
                {
                    b.Property<int>("AutomobilID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrojRegOznaka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumIstekaRegistracije")
                        .HasColumnType("datetime2");

                    b.Property<string>("Godiste")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAktivan")
                        .HasColumnType("bit");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SlikaPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VozacID")
                        .HasColumnType("int");

                    b.HasKey("AutomobilID");

                    b.HasIndex("VozacID");

                    b.ToTable("Autmobili");
                });

            modelBuilder.Entity("Carpool.WebAPI.Database.Drzava", b =>
                {
                    b.Property<int>("DrzavaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skracenica")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DrzavaID");

                    b.ToTable("Drzave");
                });

            modelBuilder.Entity("Carpool.WebAPI.Database.Grad", b =>
                {
                    b.Property<int>("GradID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrzavaID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostanskiBroj")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GradID");

                    b.HasIndex("DrzavaID");

                    b.ToTable("Gradovi");
                });

            modelBuilder.Entity("Carpool.WebAPI.Database.Korisnik", b =>
                {
                    b.Property<int>("KorisnikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PreferencijeID")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KorisnikID");

                    b.HasIndex("GradID");

                    b.HasIndex("PreferencijeID");

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("Carpool.WebAPI.Database.Muzika", b =>
                {
                    b.Property<int>("MuzikaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KratkiOpis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zanr")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MuzikaID");

                    b.ToTable("Muzika");
                });

            modelBuilder.Entity("Carpool.WebAPI.Database.Obavijesti", b =>
                {
                    b.Property<int>("ObavijestiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumVrijemeObjave")
                        .HasColumnType("datetime2");

                    b.Property<string>("KratkiOpis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipObavijestiID")
                        .HasColumnType("int");

                    b.Property<bool>("Vaznost")
                        .HasColumnType("bit");

                    b.Property<int>("VozacID")
                        .HasColumnType("int");

                    b.HasKey("ObavijestiID");

                    b.HasIndex("TipObavijestiID");

                    b.HasIndex("VozacID");

                    b.ToTable("Obavijesti");
                });

            modelBuilder.Entity("Carpool.WebAPI.Database.Ocjene", b =>
                {
                    b.Property<int>("OcjeneID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Komentar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int>("TipOcjeneID")
                        .HasColumnType("int");

                    b.Property<int>("VoznjaID")
                        .HasColumnType("int");

                    b.HasKey("OcjeneID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("TipOcjeneID");

                    b.HasIndex("VoznjaID");

                    b.ToTable("Ocjene");
                });

            modelBuilder.Entity("Carpool.WebAPI.Database.Preferencije", b =>
                {
                    b.Property<int>("PreferencijeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Dozvoljene_zivotinje")
                        .HasColumnType("bit");

                    b.Property<bool>("Dozvoljeno_pusenje")
                        .HasColumnType("bit");

                    b.Property<int?>("MuzikaID")
                        .HasColumnType("int");

                    b.HasKey("PreferencijeID");

                    b.HasIndex("MuzikaID");

                    b.ToTable("Preferencije");
                });

            modelBuilder.Entity("Carpool.WebAPI.Database.Rezervacija", b =>
                {
                    b.Property<int>("RezervacijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumRezervacije")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<string>("OpisPrtljaga")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsputniGradId")
                        .HasColumnType("int");

                    b.Property<int>("VoznjaID")
                        .HasColumnType("int");

                    b.HasKey("RezervacijaID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("UsputniGradId");

                    b.HasIndex("VoznjaID");

                    b.ToTable("Rezervacije");
                });

            modelBuilder.Entity("Carpool.WebAPI.Database.TipObavijesti", b =>
                {
                    b.Property<int>("TipObavijestiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NazivTipa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipObavijestiID");

                    b.ToTable("TipObavijesti");
                });

            modelBuilder.Entity("Carpool.WebAPI.Database.TipOcjene", b =>
                {
                    b.Property<int>("TipOcjeneID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipOcjeneID");

                    b.ToTable("TipOcjene");
                });

            modelBuilder.Entity("Carpool.WebAPI.Database.UsputniGradovi", b =>
                {
                    b.Property<int>("UsputniGradoviID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CijenaUsputni")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<int>("GradPoRedu")
                        .HasColumnType("int");

                    b.Property<int>("VoznjaID")
                        .HasColumnType("int");

                    b.HasKey("UsputniGradoviID");

                    b.HasIndex("GradID");

                    b.HasIndex("VoznjaID");

                    b.ToTable("UsputniGradovi");
                });

            modelBuilder.Entity("Carpool.WebAPI.Database.Vozac", b =>
                {
                    b.Property<int>("VozacID")
                        .HasColumnType("int");

                    b.Property<string>("BrVozackeDozvole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumIstekaVozackeDozvole")
                        .HasColumnType("datetime2");

                    b.HasKey("VozacID");

                    b.ToTable("Vozaci");
                });

            modelBuilder.Entity("Carpool.WebAPI.Database.Voznja", b =>
                {
                    b.Property<int>("VoznjaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutomobilID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumObjave")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumPolaska")
                        .HasColumnType("datetime2");

                    b.Property<int>("GradDestinacijaID")
                        .HasColumnType("int");

                    b.Property<int>("GradPolaskaID")
                        .HasColumnType("int");

                    b.Property<bool>("IsAktivna")
                        .HasColumnType("bit");

                    b.Property<decimal>("PunaCijena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SlobodnaMjesta")
                        .HasColumnType("int");

                    b.Property<int>("VozacID")
                        .HasColumnType("int");

                    b.Property<DateTime>("VrijemePolaska")
                        .HasColumnType("datetime2");

                    b.HasKey("VoznjaID");

                    b.HasIndex("AutomobilID");

                    b.HasIndex("GradDestinacijaID");

                    b.HasIndex("GradPolaskaID");

                    b.HasIndex("VozacID");

                    b.ToTable("Voznje");
                });

            modelBuilder.Entity("Carpool.WebAPI.Database.Automobil", b =>
                {
                    b.HasOne("Carpool.WebAPI.Database.Vozac", "Vozac")
                        .WithMany("Automobili")
                        .HasForeignKey("VozacID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Carpool.WebAPI.Database.Grad", b =>
                {
                    b.HasOne("Carpool.WebAPI.Database.Drzava", "Drzava")
                        .WithMany("Gradovi")
                        .HasForeignKey("DrzavaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Carpool.WebAPI.Database.Korisnik", b =>
                {
                    b.HasOne("Carpool.WebAPI.Database.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Carpool.WebAPI.Database.Preferencije", "Preferencije")
                        .WithMany()
                        .HasForeignKey("PreferencijeID");
                });

            modelBuilder.Entity("Carpool.WebAPI.Database.Obavijesti", b =>
                {
                    b.HasOne("Carpool.WebAPI.Database.TipObavijesti", "TipObavijesti")
                        .WithMany()
                        .HasForeignKey("TipObavijestiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Carpool.WebAPI.Database.Vozac", "Vozac")
                        .WithMany()
                        .HasForeignKey("VozacID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Carpool.WebAPI.Database.Ocjene", b =>
                {
                    b.HasOne("Carpool.WebAPI.Database.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Carpool.WebAPI.Database.TipOcjene", "TipOcjene")
                        .WithMany()
                        .HasForeignKey("TipOcjeneID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Carpool.WebAPI.Database.Voznja", "Voznja")
                        .WithMany("Ocjene")
                        .HasForeignKey("VoznjaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Carpool.WebAPI.Database.Preferencije", b =>
                {
                    b.HasOne("Carpool.WebAPI.Database.Muzika", "Muzika")
                        .WithMany()
                        .HasForeignKey("MuzikaID");
                });

            modelBuilder.Entity("Carpool.WebAPI.Database.Rezervacija", b =>
                {
                    b.HasOne("Carpool.WebAPI.Database.Korisnik", "Korisnik")
                        .WithMany("Rezervacije")
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Carpool.WebAPI.Database.UsputniGradovi", "UsputniGrad")
                        .WithMany()
                        .HasForeignKey("UsputniGradId");

                    b.HasOne("Carpool.WebAPI.Database.Voznja", "Voznja")
                        .WithMany("Rezervacije")
                        .HasForeignKey("VoznjaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Carpool.WebAPI.Database.UsputniGradovi", b =>
                {
                    b.HasOne("Carpool.WebAPI.Database.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Carpool.WebAPI.Database.Voznja", "Voznja")
                        .WithMany("UsputniGradovi")
                        .HasForeignKey("VoznjaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Carpool.WebAPI.Database.Vozac", b =>
                {
                    b.HasOne("Carpool.WebAPI.Database.Korisnik", "Korisnik")
                        .WithOne("Vozac")
                        .HasForeignKey("Carpool.WebAPI.Database.Vozac", "VozacID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Carpool.WebAPI.Database.Voznja", b =>
                {
                    b.HasOne("Carpool.WebAPI.Database.Automobil", "Automobil")
                        .WithMany("Voznje")
                        .HasForeignKey("AutomobilID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Carpool.WebAPI.Database.Grad", "GradDestinacija")
                        .WithMany()
                        .HasForeignKey("GradDestinacijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Carpool.WebAPI.Database.Grad", "GradPolaska")
                        .WithMany()
                        .HasForeignKey("GradPolaskaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Carpool.WebAPI.Database.Vozac", "Vozac")
                        .WithMany()
                        .HasForeignKey("VozacID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
