namespace DotNET_Assignment.Models
{
    using System;

    public sealed class GoldCard : Card
    {
        public GoldCard(decimal turnover, Owner owner) : base(turnover, owner)
        {
        }

        protected override void CalculateDiscountRate()
        {
            if (this.Turnover >= 100)
            {
                var numberOfGrow = this.Turnover / 100;

                if (numberOfGrow >= 8)
                {
                    this.DiscountRate = 10;
                }
                else
                {
                    this.DiscountRate = 2 + Math.Floor(numberOfGrow);
                }
            }
            else
            {
                this.DiscountRate = 2;
            }
        }
    }
}