namespace MultipleInheritance
{
    public class Icecek:ISu
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public void SuKullan()
        {
            throw new System.NotImplementedException();
        }
    }
}