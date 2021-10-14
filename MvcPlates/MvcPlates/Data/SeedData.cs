using MvcPlates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlates.Data
{
    public class SeedData
    {
        public static List<Plate> Plates = new List<Plate>() {

            new Plate(){
             Id = Guid.NewGuid().ToString(),
             Brand = "Selki",
             Color = "White",
             Size = 14,
             Cost = 111.2m,
             Rating =1,
             CreatedDate = DateTime.Now.AddDays(-1),
             ModifiedDate = DateTime.Now.AddDays(-1)
            },
            new Plate(){
             Id = Guid.NewGuid().ToString(),
             Brand = "Delim",
             Color = "Brown",
             Size = 8,
             Cost = 200m,
             Rating =3,
             CreatedDate = DateTime.Now.AddDays(-2),
             ModifiedDate = DateTime.Now.AddDays(-2)
            },
            new Plate(){
             Id = Guid.NewGuid().ToString(),
             Brand = "Valko",
             Color = "Black",
             Size = 16,
             Cost = 110.8m,
             Rating =4,
             CreatedDate = DateTime.Now.AddDays(-3),
             ModifiedDate = DateTime.Now.AddDays(-3)
            },
            new Plate(){
             Id = Guid.NewGuid().ToString(),
             Brand = "Zelon",
             Color = "Blue",
             Size = 14,
             Cost = 111.2m,
             Rating =2,
             CreatedDate = DateTime.Now.AddDays(-4),
             ModifiedDate = DateTime.Now.AddDays(-4)
            },
            new Plate(){
             Id = Guid.NewGuid().ToString(),
             Brand = "Valko",
             Color = "Red",
             Size = 10,
             Cost = 200m,
             Rating =5,
             CreatedDate = DateTime.Now.AddDays(-5),
             ModifiedDate = DateTime.Now.AddDays(-5)
            },
            new Plate(){
             Id = Guid.NewGuid().ToString(),
             Brand = "Selki",
             Color = "White",
             Size = 9,
             Cost = 210m,
             Rating =4,
             CreatedDate = DateTime.Now.AddDays(-6),
             ModifiedDate = DateTime.Now.AddDays(-6)
            },
            new Plate(){
             Id = Guid.NewGuid().ToString(),
             Brand = "Delim",
             Color = "Brown",
             Size = 19,
             Cost = 111.2m,
             Rating =2,
             CreatedDate = DateTime.Now.AddDays(-7),
             ModifiedDate = DateTime.Now.AddDays(-7)
            },
            new Plate(){
             Id = Guid.NewGuid().ToString(),
             Brand = "Valko",
             Color = "Red",
             Size = 8,
             Cost = 102m,
             Rating =1,
             CreatedDate = DateTime.Now.AddDays(-8),
             ModifiedDate = DateTime.Now.AddDays(-8)
            },
            new Plate(){
             Id = Guid.NewGuid().ToString(),
             Brand = "Delim",
             Color = "Blue",
             Size = 10,
             Cost = 145m,
             Rating =5,
             CreatedDate = DateTime.Now.AddDays(-9),
             ModifiedDate = DateTime.Now.AddDays(-9)
            },
            new Plate(){
             Id = Guid.NewGuid().ToString(),
             Brand = "Valko",
             Color = "Black",
             Size = 15,
             Cost = 150m,
             Rating =3,
             CreatedDate = DateTime.Now.AddDays(-10),
             ModifiedDate = DateTime.Now.AddDays(-10)
            }
        };
    }
}
