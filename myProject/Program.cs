namespace bookStore
{
    class bird
    {
        private static int _BCounter = 0;
        private int _Distance;
        private string _Type;
        private string _Stage;

        public void SetTrans()
        {
            _BCounter++;
        }
        public int GetTrans()
        {
            return _BCounter;
        }
        public bird()
        {
            _Distance = 0;
            _Type = "";
            _Stage = "";
        }
        public bird(int i, string type, string stage)
        {
            _Distance = i;
            _Type = type;
            _Stage = stage;
        }
        public int GetFullDistance()
        {
            return _Distance;
        }
        public string GetFullType()
        {
            return _Type + _Stage;
        }
        public void SetDistance(int Mesurement)
        {
            _Distance = Mesurement;
        }
        public void SetType(string type)
        {
            _Type = type;
        }
        public void SetStage(string stage)
        {
            _Stage = stage;
        }
    }
    class myBird
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                bird Bird1 = new bird();

                Bird1.SetDistance(10);
                Bird1.SetType("Cardinal");
                Bird1.SetStage("Juvenile");
                Console.WriteLine($"ID = {Bird1.GetFullType()}, Name = {Bird1.GetFullDistance()}");
                Bird1.SetTrans();

                bird Bird2 = new bird(31, "Blue-Jay", "Adult");
                Bird2.SetTrans();


                bird Bird3 = new bird();
                Console.WriteLine("How far where you from it?: ");
                Bird3.SetDistance(int.Parse(Console.ReadLine()));
                Console.WriteLine("What type of bird was it?: ");
                Bird3.SetType(Console.ReadLine());
                Console.WriteLine("What stage of it's life was it at?: ");
                Bird3.SetStage(Console.ReadLine());
                Bird3.SetTrans();


                Console.WriteLine("How far where you from it?: ");
                int tempDistance = int.Parse(Console.ReadLine());
                Console.WriteLine("What type of bird was it?: ");
                string tempType = Console.ReadLine();
                Console.WriteLine("What stage of it's life was it at?: ");
                string tempStage = Console.ReadLine();
                bird Bird4 = new bird(tempDistance, tempType, tempStage);

                Bird4.SetTrans();


                Console.WriteLine($"You have seen {Bird1.GetTrans()} birds this week.");
                Console.WriteLine("What a good day today. Let's see the birds you saw this week");

                displayBirds(Bird1);
                displayBirds(Bird2);
                displayBirds(Bird3);
                displayBirds(Bird4);


            }
            
            static void displayBirds(bird Bird1)
            {
                Console.WriteLine($"Distance: {Bird1.GetFullDistance()}");
                Console.WriteLine($"Bird name and stage: {Bird1.GetFullType()}");
            }


        }
    }
}