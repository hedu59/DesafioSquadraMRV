// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Prototype.Infra.Data;

namespace Prototype.Infra.Data.Migrations
{
    [DbContext(typeof(PrototypeDataContext))]
    partial class PrototypeDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Prototype.Domain.Entities.Contact", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Prototype.Domain.Entities.Invitation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<long>("ContactId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric(10,2)");

                    b.Property<bool?>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(null);

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("Invitations");
                });

            modelBuilder.Entity("Prototype.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100)
                        .HasDefaultValue("admin@prototype.com");

                    b.Property<string>("Login")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Login")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50)
                        .HasDefaultValue("Admin");

                    b.Property<string>("Password")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Password")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15)
                        .HasDefaultValue("123456");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Prototype.Domain.Entities.Invitation", b =>
                {
                    b.HasOne("Prototype.Domain.Entities.Contact", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Prototype.Domain.Entities.Address", "Address", b1 =>
                        {
                            b1.Property<long>("InvitationId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("bigint")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnName("City")
                                .HasColumnType("nvarchar(100)")
                                .HasMaxLength(100);

                            b1.Property<string>("Complement")
                                .HasColumnName("Complement")
                                .HasColumnType("nvarchar(100)")
                                .HasMaxLength(100);

                            b1.Property<string>("Neighborhood")
                                .IsRequired()
                                .HasColumnName("Neighborhood")
                                .HasColumnType("nvarchar(250)")
                                .HasMaxLength(250);

                            b1.Property<string>("Number")
                                .IsRequired()
                                .HasColumnName("Number")
                                .HasColumnType("nvarchar(20)")
                                .HasMaxLength(20);

                            b1.Property<string>("PostalCode")
                                .IsRequired()
                                .HasColumnName("PostalCode")
                                .HasColumnType("nvarchar(16)")
                                .HasMaxLength(16);

                            b1.Property<string>("State")
                                .IsRequired()
                                .HasColumnName("State")
                                .HasColumnType("nvarchar(80)")
                                .HasMaxLength(80);

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnName("Street")
                                .HasColumnType("nvarchar(250)")
                                .HasMaxLength(250);

                            b1.HasKey("InvitationId");

                            b1.ToTable("Invitations");

                            b1.WithOwner()
                                .HasForeignKey("InvitationId");
                        });

                    b.OwnsOne("Prototype.Domain.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<long>("InvitationId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("bigint")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Valor")
                                .IsRequired()
                                .HasColumnName("Email")
                                .HasColumnType("nvarchar(100)")
                                .HasMaxLength(100);

                            b1.HasKey("InvitationId");

                            b1.ToTable("Invitations");

                            b1.WithOwner()
                                .HasForeignKey("InvitationId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
