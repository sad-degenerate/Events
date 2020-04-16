using Events.BL;

namespace Events.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = new Files("text.txt");
            files.Clear();

            var robot = new Robot();
            robot.OnBackMove += files.WriteFile;

            // Чтобы получить другой результат, измените seed в методе.
            robot.MoveRandom(12, 10);
        }
    }
}