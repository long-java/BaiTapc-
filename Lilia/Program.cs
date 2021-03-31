using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LyThuyet2;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*Account acc = new Account(1, "long", "123", Account.Quyen.Admin, true);
            Console.WriteLine(acc.ToString());*/

            List<Account> list = new List<Account>();
            AccountList accountList = new AccountList(list);
            accountList.AddAccount();
            
            accountList.PrintAccountList();

            /*Console.WriteLine("Nhap id can edit: ");
            int i = Int32.Parse(Console.ReadLine());
            accountList.Edit(i);
            accountList.PrintAccountList();


            Console.WriteLine("Nhap id can xoa: ");
            int ii = Int32.Parse(Console.ReadLine());
            accountList.Delete(ii);
            accountList.PrintAccountList();*/

            //Login
            Console.Write("Nhap username: ");
            string user1 = Console.ReadLine();
            Console.Write("Nhap password: ");
            string pass1 = Console.ReadLine();
            Console.WriteLine(accountList.CheckLogin(user1, pass1));


            Console.ReadLine();
        }
    }
}
