using Domain.Context;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Services.Facade;
using Services.FacadeInterfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Robo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Iniciando processo");

                var connection = @"Server=DESKTOP-TPSR5NM;Database=ViajaNet;user id=sa;password=q1w2e3r4@;Trusted_Connection=True;ConnectRetryCount=0";

                var serviceProvider = new ServiceCollection()
                    .AddDbContext<ProjectContext>
                    (options => options.UseSqlServer(connection))
                    .AddScoped<IItemFacade, ItemFacade>()
                    .AddScoped<IItemTypeFacade, ItemTypeFacade>()
                    .AddScoped<IBrowserInformationFacade, BrowserInformationFacade>()
                    .BuildServiceProvider();

                Console.WriteLine("Iniciando Facades");

                var itemFacade = serviceProvider.GetService<IItemFacade>();
                var itemTypeFacade = serviceProvider.GetService<IItemTypeFacade>();
                var browserFacade = serviceProvider.GetService<IBrowserInformationFacade>();

                Console.WriteLine("Facades iniciados");

                Console.WriteLine("Iniciando processo de salvar informações em disco");

                while (true)
                {
                    var items = itemFacade.GetAllItems();
                    var itemTypes = itemTypeFacade.GetAllItemTypes();
                    var browserInformation = browserFacade.GetAll();

                    SaveItems(items);
                    SaveItemTypes(itemTypes);
                    SaveBrowserInformations(browserInformation);

                    Thread.Sleep(100000);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ocorreu um erro" + ex.InnerException);
            }
        }

        private static void SaveItems(ICollection<Item> items)
        {
            var itemsWithoutReference = items.Select(x => new Item
            {
                Id = x.Id,
                Confirmed = x.Confirmed,
                ItemTypeId = x.ItemTypeId,
                Quantity = x.Quantity
            }).ToList();

            using (StreamWriter file = File.CreateText($"{AppDomain.CurrentDomain.BaseDirectory}\\itemsBKP.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, itemsWithoutReference);
            }

            Console.WriteLine("Items salvos com sucesso!");
        }

        private static void SaveItemTypes(ICollection<ItemType> itemTypes)
        {
            var itemTypesWithoutReference = itemTypes.Select(x => new ItemType
            {
                Id = x.Id,
                Description = x.Description
            }).ToList();

            using (StreamWriter file = File.CreateText($"{AppDomain.CurrentDomain.BaseDirectory}\\itemsTypeBKP.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, itemTypesWithoutReference);
            }

            Console.WriteLine("Tipos de item salvos com sucesso!");
        }

        private static void SaveBrowserInformations(ICollection<BrowserInformation> browserInformation)
        {
            var informationsWithoutReference = browserInformation.Select(x => new BrowserInformation
            {
                Id = x.Id,
                BrowserName = x.BrowserName,
                IPAdress = x.IPAdress,
                PageName = x.PageName
            }).ToList();

            using (StreamWriter file = File.CreateText($"{AppDomain.CurrentDomain.BaseDirectory}\\browserInformationBKP.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, informationsWithoutReference);
            }

            Console.WriteLine("Informações do browser salvos com sucesso!");
        }
    }
}
