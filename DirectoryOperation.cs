using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementApp
{
    public class DirectoryOperation : IDirectoryOperation
    {
        private readonly IDirectory directoryService;
        public DirectoryOperation(IDirectory directoryService)
        {
            this.directoryService = directoryService;
        }

        public void Entrance()
        {
            Console.WriteLine("Rehber Uygulamsina Hos Geldiniz....\n");
            Console.WriteLine("1-) Eklemek İçin 1' e basınız...");
            Console.WriteLine("2-) Silmek İçin 2' e basınız...");
            Console.WriteLine("3-) Update İçin 3' e basınız...");
            Console.WriteLine("4-) Listelemek İçin 4' e basınız...\n");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Eklemek istedigin kişinin verilerini giriniz.\n");
                    Console.WriteLine("Şimdi Girebilirsiniz.\n");
                    directoryService.Add(Start());
                    break;
                case 2:
                    Console.WriteLine("Silmek istedigin kişinin verilerini giriniz.\n");
                    Console.WriteLine("Silmek istediğiniz veriyi giriniz.\n");
                    directoryService.Delete(Start());
                    break;
                case 3:

                    Console.WriteLine("Updated etmek isteginin kişinin verilerini giriniz.\n");
                    Console.WriteLine("Değiştirmek istediginiz veriyi giriniz.\n");
                    directoryService.Update(Start());
                    break;
                case 4:
                    Console.WriteLine("Listelemek istedigin kişinin verilerini giriniz.\n");
                    directoryService.GetList();
                    break;

                default:
                    Console.WriteLine("Hata Böyle bir gün yok\n");
                    break;
            }
            Entrance();
            Console.ReadLine();
        }

        public Directory Start()
        {
            Directory item = new Directory();

            Console.WriteLine("Adini Giriniz");
            item.FirstName = Console.ReadLine();
            var firstName = item.FirstName;
            if (String.IsNullOrWhiteSpace(firstName))
            {
                Console.WriteLine("Soyadi Giriniz.");
                firstName = Console.ReadLine();
            }

            Console.WriteLine("Soyadini Giriniz");
            item.LastName = Console.ReadLine();
            var lastname = item.LastName;
            if (String.IsNullOrWhiteSpace(lastname))
            {
                Console.WriteLine("Soyadi Giriniz.");
                lastname = Console.ReadLine();

            }

            Console.WriteLine("Numarayi Giriniz.");
            item.Number = Convert.ToInt32(Console.ReadLine());
            var number = item.Number;
            if (number == null || number == 0 || number.ToString().Length <= 10)
            {
                Console.WriteLine("Numarayı kurallara göre giriniz.");
                number = Convert.ToInt32(Console.ReadLine());
            }
            return item;
        }
    }
}
