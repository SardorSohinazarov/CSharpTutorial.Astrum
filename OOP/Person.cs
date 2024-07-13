internal partial class Program
{
    public class Person
    {
        public Person(string name, string surname, bool isMale, double balance)
        {
            Balance = balance;
            Name = name;
            Surname = surname;
            IsMale = isMale;
        }

        private double balance = -5;
        public string Name { get; set; }
        public string Surname { get; set; }

        public bool IsMale { get; set; }

        public double Balance
        {
            get
            {
                if (balance < 0)
                {
                    return 0;
                }

                return balance;
            }
            set
            {
                if (value > 0)
                {
                    balance = value;
                }
            }
        }

        public string Salomlash()
        {
            var salomlashuvText = "Assalomu alaykum, Qalesiz?";

            Console.WriteLine(salomlashuvText);

            return salomlashuvText;
        }

        public string Xayrlash()
        {
            var salomlashuvText = "Hayr";

            Console.WriteLine(salomlashuvText);

            return salomlashuvText;
        }

        protected void ChangePhoneNumber()
        {

        }
    }
}