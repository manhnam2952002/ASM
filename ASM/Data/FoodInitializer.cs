using ASM.Models;
using System;
using System.Linq;

namespace project5.Data
{
    public static class FoodInitializer
    {
        public static void Initialize(ASMContext context)  
        {
            context.Database.EnsureCreated();


            if (context.Category.Any())
            {
                return;   // DB has been seeded
            }

            var categories = new Category[]
            {
            new Category{Name="Đồ ăn sáng",EnrollmentDate=DateTime.Parse("2021-11-15")},
            new Category{Name="Đồ ăn vặt",EnrollmentDate=DateTime.Parse("2021-11-14")},
            new Category{Name=" Đồ ăn tối",EnrollmentDate=DateTime.Parse("2021-11-13")},
            new Category{Name="Đồ ăn trưa",EnrollmentDate=DateTime.Parse("2021-11-12")},
            };

            foreach (Category s in categories)
            {
                context.Category.Add(s);
            }
            context.SaveChanges();

            var products = new Product[]
             {
            new Product{CategoryID=1,Name=" Phở",Price=1000,Unit=1,EnrollmentDate=DateTime.Parse("2021-11-14")},
            new Product{CategoryID=1,Name=" Bún",Price=1000,Unit=1,EnrollmentDate=DateTime.Parse("2021-11-14")},
            new Product{CategoryID=1,Name="Xôi",Price=300,Unit=3,EnrollmentDate=DateTime.Parse("2021-11-14")},
            new Product{CategoryID=2,Name="Xúc Xích",Price=1900,Unit=1,EnrollmentDate=DateTime.Parse("2021-11-15")},
            new Product{CategoryID=2,Name="Nem rán",Price=1900,Unit=1,EnrollmentDate=DateTime.Parse("2021-11-15")},
            new Product{CategoryID=3,Name="Cơm",Price=10,Unit=1,EnrollmentDate=DateTime.Parse("2021-11-14")},
            new Product{CategoryID=3,Name="Cơm nắm",Price=30,Unit=3,EnrollmentDate=DateTime.Parse("2021-11-14")},
            new Product{CategoryID=4,Name="Phở Cuốn",Price=200,Unit=22,EnrollmentDate=DateTime.Parse("2021-11-14")},
            new Product{CategoryID=4,Name="Bánh cuốn",Price=1900,Unit=14,EnrollmentDate=DateTime.Parse("2021-11-14")},
             };

            foreach (Product s in products)
            {
                context.Product.Add(s);
            }
            context.SaveChanges();
        }
    }
}