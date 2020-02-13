namespace DotNET_Assignment.Models
{
    public sealed class SilverCard : Card
    {
        public SilverCard(decimal turnover, Owner owner) : base(turnover, owner)
        {
        }
        
        protected override void CalculateDiscountRate()
        {
            if (this.Turnover > 300)
            {
                this.DiscountRate = 3.5m;
            }
            else
            {
                this.DiscountRate = 2;
            }
        }
    }
}