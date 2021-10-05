using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DemoMVC.Data;
using System;
using System.Linq;

namespace DemoMVC.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AplicationContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AplicationContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any() & context.KhachHang.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M
                    }
                );
                 context.KhachHang.AddRange(
                    new KhachHang
                    {
                       ID = 123,
                       MaNV = 123456,
                       TenNV = "Tran Thi Lua",
                       TenPhong = "View Nhin Ra Bien",
                       SDT=123456,
                       GioiTinh= "Nu"
                    },

                     new KhachHang
                    {
                       ID = 123456,
                       MaNV = 123451,
                       TenNV = "Tran Thi Lua",
                       TenPhong = "View Nhin Ra Bien",
                       SDT=123456,
                       GioiTinh= "Nu"
                    },

                     new KhachHang
                    {
                       ID = 123789,
                       MaNV = 123425,
                       TenNV = "Tran Thi Lua",
                       TenPhong = "View Nhin Ra Bien",
                       SDT=12223456,
                       GioiTinh= "Nu"
                    },

                      new KhachHang
                    {
                       ID = 1232221,
                       MaNV = 123425,
                       TenNV = "Tran Thi Lua",
                       TenPhong = "View Nhin Ra Bien",
                       SDT=12322456,
                       GioiTinh= "Nu"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}