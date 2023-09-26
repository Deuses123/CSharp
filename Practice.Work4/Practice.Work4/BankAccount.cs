using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Work4
{

    class BankAccount
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }
        public bool IsCancelled { get; private set; }

        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = 0.0m;
            IsCancelled = false;
        }

        public void Deposit(decimal amount)
        {
            if (!IsCancelled)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount:C} to account {AccountNumber}. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine($"Cannot deposit to a cancelled account ({AccountNumber}).");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (!IsCancelled && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn {amount:C} from account {AccountNumber}. New balance: {Balance:C}");
            }
            else if (IsCancelled)
            {
                Console.WriteLine($"Cannot withdraw from a cancelled account ({AccountNumber}).");
            }
            else
            {
                Console.WriteLine($"Insufficient balance in account {AccountNumber} to withdraw {amount:C}.");
            }
        }

        public void CancelAccount()
        {
            IsCancelled = true;
            Console.WriteLine($"Account {AccountNumber} has been cancelled.");
        }
    }

    class BankCard
    {
        public string CardNumber { get; private set; }
        public DateTime ExpiryDate { get; private set; }
        public bool IsBlocked { get; private set; }

        public BankCard(string cardNumber, DateTime expiryDate)
        {
            CardNumber = cardNumber;
            ExpiryDate = expiryDate;
            IsBlocked = false;
        }

        public void BlockCard()
        {
            IsBlocked = true;
            Console.WriteLine($"Card {CardNumber} has been blocked.");
        }
    }

    class Order
    {
        public string OrderNumber { get; private set; }
        public decimal Amount { get; private set; }

        public Order(string orderNumber, decimal amount)
        {
            OrderNumber = orderNumber;
            Amount = amount;
        }
    }

    class Client
    {
        public string Name { get; private set; }
        public BankAccount Account { get; private set; }
        public BankCard Card { get; private set; }

        public Client(string name, string accountNumber, string cardNumber, DateTime cardExpiryDate)
        {
            Name = name;
            Account = new BankAccount(accountNumber);
            Card = new BankCard(cardNumber, cardExpiryDate);
        }

        public void MakePayment(Order order)
        {
            if (!Card.IsBlocked)
            {
                Account.Withdraw(order.Amount);
                Console.WriteLine($"Payment for order {order.OrderNumber} has been made using card {Card.CardNumber}.");
            }
            else
            {
                Console.WriteLine($"Payment for order {order.OrderNumber} cannot be made because the card {Card.CardNumber} is blocked.");
            }
        }

        public void MakeTransfer(BankAccount recipientAccount, decimal amount)
        {
            if (!Account.IsCancelled)
            {
                Account.Withdraw(amount);
                recipientAccount.Deposit(amount);
                Console.WriteLine($"Transfer of {amount:C} from account {Account.AccountNumber} to account {recipientAccount.AccountNumber} has been completed.");
            }
            else
            {
                Console.WriteLine($"Cannot make a transfer from a cancelled account ({Account.AccountNumber}).");
            }
        }
    }

    class Administrator
    {
        public void BlockCard(BankCard card)
        {
            card.BlockCard();
            Console.WriteLine($"Card {card.CardNumber} has been blocked by the administrator.");
        }
    }
}
