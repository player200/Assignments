using System;

namespace DotNET_Assignment.Models
{
    public abstract class Card
    {
        public Card(decimal turnover, Owner owner)
        {
            this.Turnover = turnover;
            this.Owner = owner;
            CalculateDiscountRate();
        }

        public Owner Owner { get; }

        public decimal Turnover { get; }

        public decimal DiscountRate { get; protected set; }

        protected abstract void CalculateDiscountRate();
    }
}