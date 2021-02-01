using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInitializer : DropCreateDatabaseAlways<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category(){KategoriAdi="C#"},
                new Category(){KategoriAdi="Asp.net MVC"},
                new Category(){KategoriAdi="Asp.net WebForm"},
                new Category(){KategoriAdi="Windows Form App"},
            };

            foreach (var kategori in kategoriler)
            {
                context.Kategoriler.Add(kategori);
            }

            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>()
            {
                new Blog(){
                    Baslik = "C# Delegates Hakkinda"
                    , Aciklama = "C# Delegates HakkindaC# Delegates HakkindaC# Delegates Hakkinda"
                    , EklenmeTarihi = DateTime.Now.AddDays(-10)
                    , Anasayfa = true
                    , Onay = true
                    , Icerik = "C# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates Hakkinda"
                    , Resim = "1.jpg"
                    , CategoryId = 1
                },

                new Blog(){
                    Baslik = "C# Delegates Hakkinda"
                    , Aciklama = "C# Delegates HakkindaC# Delegates HakkindaC# Delegates Hakkinda"
                    , EklenmeTarihi = DateTime.Now.AddDays(-10)
                    , Anasayfa = true
                    , Onay = true
                    , Icerik = "C# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates Hakkinda"
                    , Resim = "1.jpg"
                    , CategoryId = 1
                },

                new Blog(){
                    Baslik = "C# Delegates Hakkinda"
                    , Aciklama = "C# Delegates HakkindaC# Delegates HakkindaC# Delegates Hakkinda"
                    , EklenmeTarihi = DateTime.Now.AddDays(-10)
                    , Anasayfa = false
                    , Onay = true
                    , Icerik = "C# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates Hakkinda"
                    , Resim = "1.jpg"
                    , CategoryId = 2
                },

                new Blog(){
                    Baslik = "C# Delegates Hakkinda"
                    , Aciklama = "C# Delegates HakkindaC# Delegates HakkindaC# Delegates Hakkinda"
                    , EklenmeTarihi = DateTime.Now.AddDays(-30)
                    , Anasayfa = true
                    , Onay = false
                    , Icerik = "C# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates Hakkinda"
                    , Resim = "2.jpg"
                    , CategoryId = 2
                },
               new Blog(){
                    Baslik = "C# Generic List Hakkinda"
                    , Aciklama = "C# Delegates HakkindaC# Delegates HakkindaC# Delegates Hakkinda"
                    , EklenmeTarihi = DateTime.Now.AddDays(-20)
                    , Anasayfa = false
                    , Onay = true
                    , Icerik = "C# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates Hakkinda"
                    , Resim = "2.jpg"
                    , CategoryId = 2
                },

               new Blog(){
                    Baslik = "C# Delegates"
                    , Aciklama = "C# Delegates HakkindaC# Delegates HakkindaC# Delegates Hakkinda"
                    , EklenmeTarihi = DateTime.Now.AddDays(-15)
                    , Anasayfa = true
                    , Onay = true
                    , Icerik = "C# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates Hakkinda"
                    , Resim = "3.jpg"
                    , CategoryId = 3
                },
               new Blog(){
                    Baslik = "C# Delegates Hakkinda"
                    , Aciklama = "C# Delegates HakkindaC# Delegates HakkindaC# Delegates Hakkinda"
                    , EklenmeTarihi = DateTime.Now.AddDays(-10)
                    , Anasayfa = true
                    , Onay = false
                    , Icerik = "C# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates Hakkinda"
                    , Resim = "3.jpg"
                    , CategoryId = 3
                },
               new Blog(){
                    Baslik = "C# Delegates Hakkinda"
                    , Aciklama = "C# Delegates HakkindaC# Delegates HakkindaC# Delegates Hakkinda"
                    , EklenmeTarihi = DateTime.Now.AddDays(-10)
                    , Anasayfa = false
                    , Onay = true
                    , Icerik = "C# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates Hakkinda"
                    , Resim = "3.jpg"
                    , CategoryId = 3
                },
               new Blog(){
                    Baslik = "C# Delegates Hakkinda"
                    , Aciklama = "C# Delegates HakkindaC# Delegates HakkindaC# Delegates Hakkinda"
                    , EklenmeTarihi = DateTime.Now.AddDays(-10)
                    , Anasayfa = true
                    , Onay = true
                    , Icerik = "C# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates Hakkinda"
                    , Resim = "4.jpg"
                    , CategoryId = 4
                },

               new Blog(){
                    Baslik = "C# Delegates Hakkinda"
                    , Aciklama = "C# Delegates HakkindaC# Delegates HakkindaC# Delegates Hakkinda"
                    , EklenmeTarihi = DateTime.Now.AddDays(-10)
                    , Anasayfa = true
                    , Onay = true
                    , Icerik = "C# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates Hakkinda"
                    , Resim = "4.jpg"
                    , CategoryId = 4
                },

               new Blog(){
                    Baslik = "C# Delegates Hakkinda"
                    , Aciklama = "C# Delegates HakkindaC# Delegates HakkindaC# Delegates Hakkinda"
                    , EklenmeTarihi = DateTime.Now.AddDays(-10)
                    , Anasayfa = true
                    , Onay = true
                    , Icerik = "C# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates HakkindaC# Delegates Hakkinda"
                    , Resim = "4.jpg"
                    , CategoryId = 4
                },
            };

            foreach (var blog in bloglar)
            {
                context.Bloglar.Add(blog);
            }

            context.SaveChanges();

            
            base.Seed(context);
        }
    }
}