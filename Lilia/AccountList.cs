using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class AccountList
    {
         private List<Account> _accountLists = new List<Account>();
        public AccountList()
        {

        }
        public AccountList(List<Account> accountList)
        {
            _accountLists = accountList;

        }


        public void AddAccount()
        {
            Account acc1 = new Account(1, "Long", "123", Account.Quyen.Admin, true);
            Account acc2 = new Account(2, "Lilia", "123", Account.Quyen.Admin, true);
            _accountLists.Add(acc1);
            _accountLists.Add(acc2);
        }

        public void PrintAccountList()
        {
            for (int i = 1; i <= _accountLists.Count; i++)
            {
                Account acc = _accountLists[i - 1];
                Console.WriteLine(acc.ToString());
            }
        }


        public void Edit(int Id)
        {
            for (int i = 0; i < _accountLists.Count; i++)
            {
                if (_accountLists[i].Id == Id)
                {
                    Console.Write("Nhap lai username: ");
                    string userName = Console.ReadLine();
                    Console.Write("Nhap lai password: ");
                    string passWord = Console.ReadLine();
                    _accountLists[i].Username = userName;
                    _accountLists[i].Password = passWord;
                }

            }
        }


        public void Delete(int Id)
        {
            int i = 0;
            foreach (Account account in _accountLists)
            {
                if (account.Id == Id)
                {
                    _accountLists.Remove(_accountLists[i]); break;
                }
                i++;
            }
        }


        public string CheckLogin(string userName, string passWord)
        {
            for (int i = 0; i < _accountLists.Count; i++)
            {
                if (_accountLists[i].Username == userName && _accountLists[i].Password == passWord)
                    return "Thanh cong";
                else if (_accountLists[i].Username == userName && _accountLists[i].Password == passWord)
                {
                    return "Tai khoan bi khoa";
                }
            }
            return "That bai";
        }

    }
}
