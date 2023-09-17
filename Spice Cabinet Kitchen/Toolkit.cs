namespace Toolkit
{
    internal class CommonTools
    {
        public static void Continue(string output)
        {
            Console.WriteLine($"----------------------------------\n{output}\nPress \"Z\" to continue");
            Console.ReadKey();
            Program.ReloopMain();
        }
    }
}
