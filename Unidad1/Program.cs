// See https://aka.ms/new-console-template for more information
using Unidad1.DBContext;
using Unidad1.Entidades;

Console.WriteLine("Hello, World!");
using (var context = new ProContext())
{
    var user = new User()
    {
        Name = "Elias",
        Comments = "Breve comentario",
        Password = "*********",
        Email = "sosaeliass98@gmail.com",
        Posts = "Ligero Posteo De Prueba"
    };

    context.User.Add(user);
    context.SaveChanges();
}

Console.ReadKey();
