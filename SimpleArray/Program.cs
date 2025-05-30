namespace SimpleArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //declare an array

            int[,] array2DDeclaration = new int[3, 3];
            // [0] [0] [0]
            // [0] [0] [0]
            // [0] [0] [0]

            int[,,] array3DDeclaration = new int[3, 3, 3];

            int[,] array2DInizilized = { {1,2}, {3,4} };
            // [1] [2] // row 0
            // [3] [4] // row 1

            string[,] ticTacToeField =
            {
                {"O","X","X"},
                {"O","O","X" }, 
                {"X","X","O" }
            };

            string[,] understandingIndexes =
            {
                {"0,0","0,0","0,0"},
                {"0,0","0,0","0,0"},
                {"0,0","0,0","0,0"}
            };

            Console.ReadKey();

        }
    }
}
