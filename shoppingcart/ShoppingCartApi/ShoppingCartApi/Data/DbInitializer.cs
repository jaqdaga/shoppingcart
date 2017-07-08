using ShoppingCartApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartApi.Data
{
    public class DbInitializer
    {
        public static void Initialize(ShoppingCartContext context)
        {
            context.Database.EnsureCreated();

            if (context.Products.Any())
            {
                return;
            }

            var categories = new Category[]
            {
                new Category {Name="Category 1"},
                new Category {Name="Category 2"},
                new Category {Name="Category 3"}
            };

            foreach (Category x in categories)
            {
                context.Categories.Add(x);
            }

            context.SaveChanges();

            var subcategories = new Subcategory[]
            {
                new Subcategory {Name="Subcategory 1", CategoryId=1},
                new Subcategory {Name="Subcategory 2", CategoryId=1},
                new Subcategory {Name="Subcategory 3", CategoryId=2},
                new Subcategory {Name="Subcategory 4", CategoryId=2},
                new Subcategory {Name="Subcategory 5", CategoryId=3}
            };

            foreach (Subcategory x in subcategories)
            {
                context.Subcategories.Add(x);
            }

            context.SaveChanges();

            var products = new Product[]
            {
                new Product {Name="Product 1", SubcategoryId=1},
                new Product {Name="Product 2", SubcategoryId=1},
                new Product {Name="Product 3", SubcategoryId=2},
                new Product {Name="Product 4", SubcategoryId=2},
                new Product {Name="Product 5", SubcategoryId=3},
                new Product {Name="Product 6", SubcategoryId=3},
                new Product {Name="Product 7", SubcategoryId=4},
                new Product {Name="Product 8", SubcategoryId=4},
                new Product {Name="Product 9", SubcategoryId=5},
                new Product {Name="Product 10", SubcategoryId=5}
            };

            foreach (Product x in products)
            {
                context.Products.Add(x);
            }

            context.SaveChanges();

            var roles = new Role[]
            {
                new Role {Name="Administrador"}
            };

            foreach (Role x in roles)
            {
                context.Roles.Add(x);
            }

            context.SaveChanges();

            var users = new User[]
            {
                // Encryption: SHA256
                // 8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92 = 123456
                new User {Name="Joel Francia",Email="pcsijfra@upc.edu.pe",Password="8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92",PhoneNumber="972770306",Salary=1000000,RoleId=1},
                new User {Name="Jorge Quispe",Email="u201217239@upc.edu.pe",Password="8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92",PhoneNumber="987431769",Salary=1000000,RoleId=1},
                new User {Name="Hugo del Solar",Email="u201221864@upc.edu.pe",Password="8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92",PhoneNumber="940199682",Salary=1000000,RoleId=1},
                new User {Name="Ricardo Silva",Email="u201313885@upc.edu.pe",Password="8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92",PhoneNumber="972770306",Salary=1000000,RoleId=1}
            };

            foreach (User x in users)
            {
                context.Users.Add(x);
            }

            context.SaveChanges();
        }
    }
}
