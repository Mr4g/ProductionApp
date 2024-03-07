using ProductionApp.Data;
using ProductionApp.Entities;
using ProductionApp.Repositories;


var machineRepository = new SqlRepository<Machine>(new ProductionAppDbContext());

AddMachine(machineRepository);
AddPrinter(machineRepository);
AddAgvOnLogistic(machineRepository);
WriteAllToConsole(machineRepository);

static void AddMachine(IRepository<Machine> machineRepository)
{
    machineRepository.Add(new Machine { Name = "TH1", Manufacturer = "Siemens", YearOfManufacture = 2000});
    machineRepository.Add(new Machine { Name = "TH2", Manufacturer = "Siemens", YearOfManufacture = 2001});
    machineRepository.Add(new Machine { Name = "TH3", Manufacturer = "Omron", YearOfManufacture = 2003});
    machineRepository.Save();
}

static void AddPrinter(IWriteRepository<Printer> printerRepository)
{
    printerRepository.Add(new Printer { Name = "LX1", Manufacturer = "Brady", YearOfManufacture = 2010, KindOfLabel = "RFID"});
    printerRepository.Add(new Printer { Name = "LX2", Manufacturer = "Zebra", YearOfManufacture = 2015, KindOfLabel = "STANDARD"});
    printerRepository.Save();
}

static void AddAgvOnLogistic(IWriteRepository<AgvOnLogistic> agvRepository)
{
    agvRepository.Add(new AgvOnLogistic { Name = "AGV02", Manufacturer = "Omron", YearOfManufacture = 2018, Size = 'M', Speed = 10 });
    agvRepository.Add(new AgvOnLogistic { Name = "AGV03", Manufacturer = "Omron", YearOfManufacture = 2018, Size = 'X', Speed = 15 });
    agvRepository.Save();
}


static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}
