using System;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogOwner;
            string dogName;
            double dogWeight;
            int dogDays;
            string serviceCode;

            Console.WriteLine("Welcome to MPLS DogBoarding!");
            Console.WriteLine("Please, Input Owner name.");
            dogOwner = Console.ReadLine();
            Console.WriteLine("Input Dog name.");
            dogName = Console.ReadLine();
            Console.WriteLine("Input Dog weight.");
            dogWeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input Days Dog will be staying.");
            dogDays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Service Code;\n A for Bath/Groom ($169/day)\n C for Bath Only ($112/day)\n N for no additional service ($75/day)");
            serviceCode = Console.ReadLine();
            Estimate aBill = new Estimate(dogOwner, dogName, dogWeight, dogDays, serviceCode);
            Console.WriteLine(aBill);
            Console.WriteLine("Thank you for choosing MPLS DogBoarding. Have a Fantastic day!");
        }
    }
    class Estimate
    {
        public string dogOwner {get;set;}
        public string dogName {get;set;}
        public double dogWeight {get;set;}
        public int dogDays {get;set;}
        public string serviceCode {get;set;}
        public double costEstimate {get;set;}

        private const double CODE_A = 169.00;
        private const double CODE_C = 112.00;
        private const double CODE_N = 75.00;

        public Estimate(){

        }
        public Estimate(string owner, string name, double weight, int days, string code){
            this.dogOwner = owner;
            this.dogName = name;
            this.dogWeight = weight;
            this.dogDays = days;
            this.serviceCode = code;
            billEstimate();
        }

        private void billEstimate(){
            while(this.serviceCode != "A" && this.serviceCode != "C" && this.serviceCode != "N"){
                Console.WriteLine("Invalid input, please try again");
                this.serviceCode = Console.ReadLine();
            }
            if(this.serviceCode == "A"){
                this.costEstimate += this.dogDays * CODE_A;
            }else if(this.serviceCode == "C"){
                this.costEstimate += this.dogDays * CODE_C;
            }else{
                this.costEstimate += this.dogDays * CODE_N;
            }
        }
        public override string ToString(){
            return String.Format($"{dogOwner}'s dog; '{dogName}'\n Weight: {dogWeight}\n Days: {dogDays}\n Code: {serviceCode}\n Total cost: ${costEstimate}");
        }
    }
}
