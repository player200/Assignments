namespace DotNET_Assignment.Models
{
    public sealed class BronzeCard : Card
    {
        public BronzeCard(decimal turnover, Owner owner) : base(turnover, owner)
        {
        }

        protected override void CalculateDiscountRate()
        {
            if (this.Turnover < 100)
            {
                this.DiscountRate = 0;
            }
            else if (this.Turnover >= 100 && this.Turnover <= 300)
            {
                this.DiscountRate = 1;
            }
            else
            {
                this.DiscountRate = 2.5m;
            }
        }
    }
}