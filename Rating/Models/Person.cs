namespace Rating.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }
        public decimal MonthlyPay { get; set; }
        public int Id { get; set; }
        private static int instanceCounter = 0;

        public Person()
        {
            Id = instanceCounter;
            instanceCounter++;
        }
        public Person(string name, int age, string type, decimal monthlyPay)
        {
            Name = name;
            Age = age;
            Type = type;
            MonthlyPay = monthlyPay;
        }
        public override string ToString()
        {
            return $"{this.Name}\n{this.Age}\n{this.Type}\n{this.MonthlyPay}";
        }
    }
}
