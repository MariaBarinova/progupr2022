//Запросы


// Простая проекция
using Microsoft.EntityFrameworkCore;
using Praktica;

Console.WriteLine(" ------------Простая проекция");
using (ApplicationContext db = new ApplicationContext())
{

    var clients = db.Client.ToArray().Select(p => p.Telephon);
    foreach (var p in clients)
    {
        Console.WriteLine(p);
    }


}



// Анонимный объект
Console.WriteLine(" ------------Анонимный объект");
using (ApplicationContext db = new ApplicationContext())
{
    var clients = db.Client.ToArray().Select(p => new
    {
        Telephon = p.Telephon + "(New obj)",
        Inn = p.Inn * 2
    });
    foreach (var p in clients)
    {
        Console.WriteLine(p.Telephon + " " + p.Inn);
    }

}

// Переменные в операторах Linq
Console.WriteLine(" ----------Переменные в операторах Linq");
using (ApplicationContext db = new ApplicationContext())
{
    var client = from p in db.Client.ToArray()
                 let inn = p.Inn * 2
                 select new
                 {
                     Telephon = p.Telephon + "(New obj)",
                     Inn = p.Inn
                 };

    foreach (var p in client)
    {
        Console.WriteLine(p.Inn + " " + p.Telephon);
    }

}

// Декартово произведение
Console.WriteLine(" -----------Декартово произведение");
using (ApplicationContext db = new ApplicationContext())
{
    var clients = from u in db.Client.ToArray()
                  from c in db.Contracts.ToArray()
                  select new
                  {
                      Telephon = u.Telephon,
                      Contract = c.ContractCode
                  };
    foreach (var p in clients)
    {
        Console.WriteLine(p.Telephon + " " + p.Contract);
    }

}


// Фильтрация коллекции
Console.WriteLine(" ------------Фильтрация коллекции");
using (ApplicationContext db = new ApplicationContext())
{
    var clients = db.Client.ToArray().Where(p => p.Id <= 2).Select(p => p.Inn);
    foreach (var p in clients)
    {
        Console.WriteLine(p);
    }


}


//Сортировка коллекции
Console.WriteLine(" ------------Сортировка коллекции");
using (ApplicationContext db = new ApplicationContext())
{
    var clients = db.Client.ToArray().OrderBy(u => u.Telephon);
    foreach (var p in clients)
    {

        Console.WriteLine(p.Telephon);
    }

}

//Объединение таблиц
Console.WriteLine(" ------------Объединение таблиц");
using (ApplicationContext db = new ApplicationContext())
{
    var Clients = db.Client.ToArray().Join(db.Contracts.ToArray(), u => u.Id, c => c.Id, (u, c) => new { client = u.Telephon, contract = c.ContractCode });
    foreach (var p in Clients)
    {
        Console.WriteLine(p.client + " " + p.contract);
    }

}

//Загрузка связанных данных
Console.WriteLine(" ------------Загрузка связанных данных");

// Переменные в операторах Linq
Console.WriteLine(" ----------Переменные в операторах Linq");
using (ApplicationContext db = new ApplicationContext())
{
    var clients = from p in db.Client.ToArray()
                  let Inn = p.Inn * 2
                  select new
                  {
                      Inn = p.Inn + "(New obj)",
                      Telephon = p.Telephon
                  };

    foreach (var p in clients)
    {
        Console.WriteLine(p.Inn + " " + p.Telephon);
    }

}

// Декартово произведение
Console.WriteLine(" -----------Декартово произведение");
using (ApplicationContext db = new ApplicationContext())
{
    var clients = from u in db.Client.ToArray()
                  from c in db.Contracts.ToArray()
                  select new
                  {
                      Inn = u.Inn,
                      Contract = c.ContractCode
                  };
    foreach (var p in clients)
    {
        Console.WriteLine(p.Inn + " " + p.Contract);
    }

}


// Фильтрация коллекции
Console.WriteLine(" ------------Фильтрация коллекции");
using (ApplicationContext db = new ApplicationContext())
{
    var clients = db.Client.ToArray().Where(p => p.Id <= 5).Select(p => p.Telephon);
    foreach (var p in clients)
    {
        Console.WriteLine(p);
    }


}


//Сортировка коллекции
Console.WriteLine(" ------------Сортировка коллекции");
using (ApplicationContext db = new ApplicationContext())
{
    var clients = db.Client.ToArray().OrderBy(u => u.Telephon);
    foreach (var p in clients)
    {

        Console.WriteLine(p.Telephon);
    }

}

//Объединение таблиц
Console.WriteLine(" ------------Объединение таблиц");
using (ApplicationContext db = new ApplicationContext())
{

    var clients = db.Client.ToArray().Join(db.Contracts.ToArray(), u => u.Id, c => c.Id, (u, c) => new { client = u.Telephon, contract = c.ContractCode });
    foreach (var p in clients)
    {
        Console.WriteLine(p.client + " " + p.contract);
    }

}

//Загрузка связанных данных
Console.WriteLine(" ------------Загрузка связанных данных");

using (ApplicationContext db = new ApplicationContext())
{


    var client = db.Client.Include(u => u.Contracts).ToArray();



    foreach (var p in client)
    {
        Console.WriteLine(p.Id + " " + p.Contract?.Id);
    }



}


//Select Many
Console.WriteLine(" ------------Select Many");
using (ApplicationContext db = new ApplicationContext())
{

    var contracts = db.Client.SelectMany(u => u.Contracts, (u, l) => new { Inn = u.Inn, ContractCode = l.ContractCode });
    foreach (var p in contracts)
    {
        Console.WriteLine(p.Inn + " " + p.ContractCode);
    }

}

