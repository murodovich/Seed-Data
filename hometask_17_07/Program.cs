using hometask_17_07.Data;
using hometask_17_07.Models;
using hometask_17_07.Servises;
using Microsoft.EntityFrameworkCore;


namespace HomeTask_17_07_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GMDBcontext db = new GMDBcontext();
            DBMethods<Bus> busMethod = new DBMethods<Bus>();
            DBMethods<Car> carMethod = new DBMethods<Car>();
            DBMethods<Client> clientMethod = new DBMethods<Client>();

            var client = db.Clients.FirstOrDefault(x => x.Name == "sarvar");
            var car = db.Cars.Where(x => x.Id > 1).ToList();

            //client.Cars = car;
            //db.SaveChanges();

            var clients = db.Clients.Include(x => x.Cars)
                .Where(x => x.Id == 1)
                .AsNoTracking()
                .ToList();

            foreach (var item in clients)
            {
                Console.WriteLine(item.Name);
                foreach (var item1 in item.Cars)
                {
                    Console.WriteLine("-----" + item1.Id);
                    Console.WriteLine("-----" + item1.Name);
                    Console.WriteLine("-----" + item1.Speed);
                    Console.WriteLine();
                }
            }



        }
    }
}
