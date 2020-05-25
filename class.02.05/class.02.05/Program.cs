using System;

namespace newTask
{
    class Program
{
    static void Main(string[] args)
    {
            Invoince invoince = new Invoince("Ayan","Fexri","Fox");
            invoince.article = "Laptop";
            invoince.quantity = "6";
            invoince.CostCalc(true);


    }

    }
    class Invoince
    {
        private readonly string account;
        private readonly string customer;
        private readonly string provider;
        public string article { get; set; }
        public string quantity { get; set; } 
        float cost;
        float edv;
        public Invoince(string account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;

        }
        private void GetCost()
        {
            switch (article)
            {
                case "Laptop":
                    {
                        cost = 1000;
                        break;
                    }
                case "SD":
                    {
                        cost = 30;
                        break;
                    }
                case "USB":
                    {
                        cost = 12;
                    }
                    break;
            }
        }
        public void CostCalc(bool needEDV)
        {
            GetCost();
            if (needEDV)
            {
                edv = cost * 0.18F;
                cost = cost * float.Parse(quantity) + edv;
            }
            else
            {
                cost = cost * float.Parse(quantity);
            }
           Console.WriteLine($"Account : {account}, Customer: {customer},Article : {article}, Quantity: {quantity} Provider: {provider} Cost: {cost}");
        }
    }
}
