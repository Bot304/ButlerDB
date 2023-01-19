using System;
using System.Linq;
using ButlerDataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace ButlerDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DBContext db = new DBContext())
            {
                // получаем объекты из бд и выводим на консоль
                var users = db.Explications.ToList();
                Console.WriteLine("Список объектов:");
                foreach (Explication u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Floor} - {u.Room}");
                }
            }
        }
    }
}
