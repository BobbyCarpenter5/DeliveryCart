// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DeliveryCart.Migrations
{
    [DbContext(typeof(DeliveryCartContext))]
    [Migration("20220916170829_NewMigration")]
    partial class NewMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("DeliveryCart.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CustomerAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerPhone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("DeliveryCart.Models.Shopper", b =>
                {
                    b.Property<int>("ShopperID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ShopperEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ShopperName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ShopperPhone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ShopperID");

                    b.ToTable("Shopper");
                });
#pragma warning restore 612, 618
        }
    }
}
