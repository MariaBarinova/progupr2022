using Microsoft.EntityFrameworkCore;
using Praktica;

//Вывод упорядоченной базы контрактов
Console.WriteLine("Вывод упорядоченной базы контрактов");
using (ApplicationContext db = new ApplicationContext())
{
    var clients = db.Contracts.ToArray().OrderBy(u => u.Id);
    foreach (var p in clients)
    {

        Console.WriteLine(p);
    }

}

//Вывод базы клиентов, соответствующей нужному запросу с их номерами контрактов
Console.WriteLine(" ------------Вывод базы клиентов, соответствующей нужному запросу с их номерами контрактов");
using (ApplicationContext db = new ApplicationContext())
{
    var clients = db.Client.ToArray().Where(p => p.Id == 1).Select(p => p.Inn);
    foreach (var p in clients)
    {
        Console.WriteLine(p);
    }


}
//Вывод контрактов, в которых клиент участвует
Console.WriteLine(" ------------Вывод контрактов, в которых клиент участвует");
using (ApplicationContext db = new ApplicationContext())
{
    var clients = db.Contracts.ToArray().Where(p => p.ClientId == 1).Select(p => p.Id);
    foreach (var p in clients)
    {
        Console.WriteLine(p);
    }


}

//Удаление истёкшего контракта
using (ApplicationContext db = new ApplicationContext())
{
    Contract? deluser = (from contract in db.Contracts where contract.Id == 1 select contract).First();
    if (deluser != null)
    {
        db.Contracts.Remove(deluser);
        db.SaveChanges();
    }
    var contracts = db.Contracts.ToArray();
    Console.WriteLine("Список объектов");
    foreach (Contract u in contracts)
    {
        Console.WriteLine(u.Id + " - " + u.ClientId);
    }

}

//Обновление старого контракта
using (ApplicationContext db = new ApplicationContext())
{
    Contract? upduser = (from contract in db.Contracts where contract.Id == 4 select contract).First();
    if (upduser != null)
    {
        upduser.ContractCode = upduser.ContractCode = 4;
        db.SaveChanges();
    }
    var contracts = db.Contracts.ToArray();
    Console.WriteLine("Список объектов");
    foreach (Contract u in contracts)
    {
        Console.WriteLine(u.Id + " - " + u.ContractCode);
    }

}
//Добавление нового контракта
using (ApplicationContext db = new ApplicationContext())
{

    var contract = db.Contracts.Where(c => c.Id == 1).FirstOrDefault();

    Contract new_contract = new Contract { Id = 5, ContractCode = 3, ClientId = 3, RentaCode = 4 };


    db.Contracts.Add(new_contract);

    db.SaveChanges();


}