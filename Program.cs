using System;
public class Program
{
    static void Main(string[]args)
    {
        ShopInfo shopinfo = new ShopInfo();
        shopinfo.Cost = "1,000,000";
        shopinfo.Shopname = "KFC";
        shopinfo.Location = "Bang khun Dhian";
        PrintShopInformation(shopinfo);
        

        CoFounder cofounder = new CoFounder();
        cofounder.CoName1 = "Tavee";
        cofounder.CoSurname1 = "JaiDEEDEE";
        cofounder.CoID1 = "153-698-4561237";
        cofounder.CoName2 = "Yutthadee";
        cofounder.CoSurname2 = "Thangjairein";
        cofounder.CoID2 = "742-112-5687412";
        cofounder.CoName3 = "JAME";
        cofounder.CoSurname3 = "rakSchool";
        cofounder.CoID3 = "541-772-3215689";
        PrintCofounderInformation(cofounder);

        Worker worker = new Worker();
        worker.WorkerType1 = "Shopworker";
        worker.WorkerType2 = "Delivery";
        worker.Salary1 = "15,000";
        worker.Salary2 = "12,500";
        worker.Workname1 = "chaidee rakdee";
        worker.WorkAge1 = "20";
        worker.Workname2 = "Nondee jaidee";
        worker.WorkAge2 = "18";
        worker.Workname3 = "Apaidee reindee";
        worker.WorkAge3 = "22";
        worker.Workname4 = "Thamdee ngandee";
        worker.WorkAge4 = "25";
        worker.Workname5 = "Nondee reapdee";
        worker.WorkAge5 = "23";
        PrintWorkerInformation(worker);
        

    }
    static void PrintCofounderInformation(CoFounder cofounder)
    {
        Console.WriteLine("--------CoFounderInFo:------------");
        Console.WriteLine("Cofounder number1:{0} _ {1} _ {2}",cofounder.CoName1, cofounder.CoSurname1, cofounder.CoID1);
        Console.WriteLine("Cofounder number2:{0} _ {1} _ {2}",cofounder.CoName2, cofounder.CoSurname2, cofounder.CoID2);
        Console.WriteLine("Cofounder number3:{0} _ {1} _ {2}",cofounder.CoName3, cofounder.CoSurname3, cofounder.CoID3);
        Console.Write("----------------------------------");
    }  
    static void PrintShopInformation(ShopInfo shopinfo)
    {
        Console.WriteLine("------------Shop information-----------");
        Console.WriteLine("Shopcost:{0}",shopinfo.Cost);
        Console.WriteLine("Shopname:{0}",shopinfo.Shopname);
        Console.WriteLine("Shop Location:{0}",shopinfo.Location);
        Console.WriteLine("--------------------------------------");
    }
    static void PrintWorkerInformation(Worker worker)
    {
        Console.WriteLine("-----------Work information----------");
        Console.WriteLine("Worker1:Role:{0} Name:{1} Age:{2}",worker.WorkerType1, worker.Workname1, worker.WorkAge1);
        Console.WriteLine("Worker2:Role:{0} Name:{1} Age:{2}",worker.WorkerType1, worker.Workname2, worker.WorkAge2);
        Console.WriteLine("Worker3:Role:{0} Name:{1} Age:{2}",worker.WorkerType1, worker.Workname3, worker.WorkAge3);
        Console.WriteLine("Worker4:Role:{0} Name:{1} Age:{2}",worker.WorkerType2, worker.Workname4, worker.WorkAge4);
        Console.WriteLine("Worker5:Role:{0} Name:{1} Age:{2}",worker.WorkerType2, worker.Workname5, worker.WorkAge5);
        Console.Write("-----------------------------");
    }
}
