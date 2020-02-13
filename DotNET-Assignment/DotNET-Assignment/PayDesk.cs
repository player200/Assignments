namespace DotNET_Assignment
{
    using DotNET_Assignment.Models;
    using System;
    using System.Text;

    public static class PayDesk
    {
        public static void PrintInformation(Card card, decimal purchaseValue)
        {
            StringBuilder sb = new StringBuilder()
                .AppendLine($"Purchase value: ${Math.Round(purchaseValue, 2):f2}")
                .AppendLine($"Discount rate: {Math.Round(card.DiscountRate, 1):f1}%")
                .AppendLine($"Discount: ${CalculateDiscount(purchaseValue, card.DiscountRate):f2}")
                .AppendLine($"Total: ${CalculateTotal(purchaseValue, CalculateDiscount(purchaseValue, card.DiscountRate)):f2}");

            Console.WriteLine(sb.ToString());
        }

        private static decimal CalculateDiscount(decimal purchaseValue, decimal discountRate)
        {
            var result = (purchaseValue / 100) * discountRate;

            return Math.Round(result, 2);
        }

        private static decimal CalculateTotal(decimal purchaseValue, decimal discount)
        {
            var result = purchaseValue - discount;

            return Math.Round(result, 2);
        }
    }
}