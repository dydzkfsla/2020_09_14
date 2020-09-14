using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_14
{
    public class BankAccount
    {
        //초기화 및 접근 제한
        private double interest = 0.2;      //이자율
        private string accNum = "Not AccNum";                      //계좌번호
        private string name = "Not name";                         //예금주명
        private int balance = 0;


        public int Balance                          //접근 및 조건
        { 
            get => balance; 
            set 
            {
                if (value < 0)
                    balance = 0;
                else
                    balance = value;
            }
        }
        public string AccNum { get => accNum; }
        public string Name   { get => name; }
        public double Interset { get => interest; }

        public BankAccount(string accNum, string name)
        {
            this.accNum = accNum;
            this.name = name;
        }

        public void OutputMoney(int amount)
        {
            this.Balance = this.Balance - amount;
            Console.WriteLine($"{name}의 계좌 {accNum} 에서 {amount.ToString("c")} 원만큼 출금이 있습니다.\n 잔액은 {Balance.ToString("c")}원 입니다.");//원표시
        }

        public void InputMoney(int amount)
        {
            this.Balance = this.Balance + amount;
            Console.WriteLine($"{name}의 계좌 {accNum} 에서 {amount.ToString("c")} 원만큼 입금이 있습니다.\n 잔액은 {Balance.ToString("c")}원 입니다.");
        }

        public void AddInterest()
        {
            Balance += (int)(Balance * interest);
            Console.WriteLine($"{name}의 계좌 {accNum} 에서 {interest*100}% 의이자를 받았습니다.\n 잔액은 {Balance.ToString("c")}원 입니다.");
        }
    }
    public class Pa
    {
        static void Main()
        {
            BankAccount bank = new BankAccount("11-11-11", "사람1");

            bank.Balance = 500000;
            bank.OutputMoney(1000);
            bank.InputMoney(20000);
            bank.AddInterest();

            bank.Balance = -10000;
            Console.WriteLine($"{bank.Name}의 통장 {bank.AccNum}에 남은 잔액은 {bank.Balance} 이자율은 {bank.Interset}");
        }
    }
}
