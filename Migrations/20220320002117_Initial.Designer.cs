// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Temple.Models;

namespace Temple.Migrations
{
    [DbContext(typeof(AppointmentContext))]
    [Migration("20220320002117_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Temple.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Available")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupSize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("AppointmentId");

                    b.ToTable("Appointment");

                    b.HasData(
                        new
                        {
                            AppointmentId = 1,
                            Available = true,
                            Date = new DateTime(2022, 3, 22, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 2,
                            Available = true,
                            Date = new DateTime(2022, 3, 22, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 3,
                            Available = true,
                            Date = new DateTime(2022, 3, 22, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 4,
                            Available = true,
                            Date = new DateTime(2022, 3, 22, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 5,
                            Available = true,
                            Date = new DateTime(2022, 3, 22, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 6,
                            Available = true,
                            Date = new DateTime(2022, 3, 22, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 7,
                            Available = true,
                            Date = new DateTime(2022, 3, 22, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 8,
                            Available = true,
                            Date = new DateTime(2022, 3, 22, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 9,
                            Available = true,
                            Date = new DateTime(2022, 3, 22, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 10,
                            Available = true,
                            Date = new DateTime(2022, 3, 22, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 11,
                            Available = true,
                            Date = new DateTime(2022, 3, 22, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 12,
                            Available = true,
                            Date = new DateTime(2022, 3, 22, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 13,
                            Available = true,
                            Date = new DateTime(2022, 3, 22, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 14,
                            Available = true,
                            Date = new DateTime(2022, 3, 23, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 15,
                            Available = true,
                            Date = new DateTime(2022, 3, 23, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 16,
                            Available = true,
                            Date = new DateTime(2022, 3, 23, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 17,
                            Available = true,
                            Date = new DateTime(2022, 3, 23, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 18,
                            Available = true,
                            Date = new DateTime(2022, 3, 23, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 19,
                            Available = true,
                            Date = new DateTime(2022, 3, 23, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 20,
                            Available = true,
                            Date = new DateTime(2022, 3, 23, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 21,
                            Available = true,
                            Date = new DateTime(2022, 3, 23, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 22,
                            Available = true,
                            Date = new DateTime(2022, 3, 23, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 23,
                            Available = true,
                            Date = new DateTime(2022, 3, 23, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 24,
                            Available = true,
                            Date = new DateTime(2022, 3, 23, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 25,
                            Available = true,
                            Date = new DateTime(2022, 3, 23, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 26,
                            Available = true,
                            Date = new DateTime(2022, 3, 23, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 27,
                            Available = true,
                            Date = new DateTime(2022, 3, 24, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 28,
                            Available = true,
                            Date = new DateTime(2022, 3, 24, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 29,
                            Available = true,
                            Date = new DateTime(2022, 3, 24, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 30,
                            Available = true,
                            Date = new DateTime(2022, 3, 24, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 31,
                            Available = true,
                            Date = new DateTime(2022, 3, 24, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 32,
                            Available = true,
                            Date = new DateTime(2022, 3, 24, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 33,
                            Available = true,
                            Date = new DateTime(2022, 3, 24, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 34,
                            Available = true,
                            Date = new DateTime(2022, 3, 24, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 35,
                            Available = true,
                            Date = new DateTime(2022, 3, 24, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 36,
                            Available = true,
                            Date = new DateTime(2022, 3, 24, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 37,
                            Available = true,
                            Date = new DateTime(2022, 3, 24, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 38,
                            Available = true,
                            Date = new DateTime(2022, 3, 24, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 39,
                            Available = true,
                            Date = new DateTime(2022, 3, 24, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 40,
                            Available = true,
                            Date = new DateTime(2022, 3, 25, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 41,
                            Available = true,
                            Date = new DateTime(2022, 3, 25, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 42,
                            Available = true,
                            Date = new DateTime(2022, 3, 25, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 43,
                            Available = true,
                            Date = new DateTime(2022, 3, 25, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 44,
                            Available = true,
                            Date = new DateTime(2022, 3, 25, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 45,
                            Available = true,
                            Date = new DateTime(2022, 3, 25, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 46,
                            Available = true,
                            Date = new DateTime(2022, 3, 25, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 47,
                            Available = true,
                            Date = new DateTime(2022, 3, 25, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 48,
                            Available = true,
                            Date = new DateTime(2022, 3, 25, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 49,
                            Available = true,
                            Date = new DateTime(2022, 3, 25, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 50,
                            Available = true,
                            Date = new DateTime(2022, 3, 25, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 51,
                            Available = true,
                            Date = new DateTime(2022, 3, 25, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 52,
                            Available = true,
                            Date = new DateTime(2022, 3, 25, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 53,
                            Available = true,
                            Date = new DateTime(2022, 3, 26, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 54,
                            Available = true,
                            Date = new DateTime(2022, 3, 26, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 55,
                            Available = true,
                            Date = new DateTime(2022, 3, 26, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 56,
                            Available = true,
                            Date = new DateTime(2022, 3, 26, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 57,
                            Available = true,
                            Date = new DateTime(2022, 3, 26, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 58,
                            Available = true,
                            Date = new DateTime(2022, 3, 26, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 59,
                            Available = true,
                            Date = new DateTime(2022, 3, 26, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 60,
                            Available = true,
                            Date = new DateTime(2022, 3, 26, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 61,
                            Available = true,
                            Date = new DateTime(2022, 3, 26, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 62,
                            Available = true,
                            Date = new DateTime(2022, 3, 26, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 63,
                            Available = true,
                            Date = new DateTime(2022, 3, 26, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 64,
                            Available = true,
                            Date = new DateTime(2022, 3, 26, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 65,
                            Available = true,
                            Date = new DateTime(2022, 3, 26, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 66,
                            Available = true,
                            Date = new DateTime(2022, 3, 27, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 67,
                            Available = true,
                            Date = new DateTime(2022, 3, 27, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 68,
                            Available = true,
                            Date = new DateTime(2022, 3, 27, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 69,
                            Available = true,
                            Date = new DateTime(2022, 3, 27, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 70,
                            Available = true,
                            Date = new DateTime(2022, 3, 27, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 71,
                            Available = true,
                            Date = new DateTime(2022, 3, 27, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 72,
                            Available = true,
                            Date = new DateTime(2022, 3, 27, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 73,
                            Available = true,
                            Date = new DateTime(2022, 3, 27, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 74,
                            Available = true,
                            Date = new DateTime(2022, 3, 27, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 75,
                            Available = true,
                            Date = new DateTime(2022, 3, 27, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 76,
                            Available = true,
                            Date = new DateTime(2022, 3, 27, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 77,
                            Available = true,
                            Date = new DateTime(2022, 3, 27, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        },
                        new
                        {
                            AppointmentId = 78,
                            Available = true,
                            Date = new DateTime(2022, 3, 27, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupSize = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
