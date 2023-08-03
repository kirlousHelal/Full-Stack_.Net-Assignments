namespace Assignment_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Ball ball = new Ball();


            Player p11 = new Player() { Name = "P11" , Team = "Team 01"};
            Player p12 = new Player() { Name = "P12", Team = "Team 01" };
            Player p22 = new Player() { Name = "P21", Team = "Team 02" };
            Player p21 = new Player() { Name = "P22", Team = "Team 02" };
            Refree refree = new Refree() { Name = "refree"};

            
            
            ball.Ball_location = new Location() {X = 10,Y = 20,Z = 30 };

            Console.WriteLine(ball);

            ball.ball_changed += p11.Run;
            ball.ball_changed += p12.Run;
            ball.ball_changed += p21.Run;
            ball.ball_changed += p22.Run;
            ball.ball_changed += refree.Look;

            ball.ball_changed += (Location loc) => { Console.WriteLine($"Lamda Expression @ {loc}"); };

            ball.Ball_location = new Location() {X = 30,Y = 40,Z = 60 };



        }
    }
}