using _3_modul.Lesson3_Events.Homework.Card.Expetions;
using _3_modul.Lesson3_Events.Homework.Card.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace _3_modul.Lesson3_Events.Homework.Card
{
    public class Card
    {
        private Currency Currency { get; set; }
        public int Id { get; set; }
        public string? Owner { get; set; }
        public double Balance { get; set; }
        public CardType CardType { get; init; }

        public Card(CardType cardType)
        {
            if (cardType == CardType.Visa || cardType == CardType.UnionPay) Currency = Currency.USD;
            else Currency = Currency.UZS;
        }

        public void Transaction(Card card)
        {
            if (this.Currency != card.Currency) throw new ExceptionCardTypeNotMatch();
            
            Console.Write("Amount: ");
            double amount;
            string? str = Console.ReadLine();
            double.TryParse(str, out amount);

            if(this.Balance < amount) throw new ExceptionNotEnoughMoney();

            this.Balance -= amount;
            card.Balance += amount;

            Console.WriteLine("Successfully");

        }

    }
}
