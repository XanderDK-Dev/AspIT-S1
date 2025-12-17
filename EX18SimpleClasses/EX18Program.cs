namespace EX18SimpleClasses
{
    internal class EX18Program
    {
        static void Main(string[] args)
        {
            Box b = new Box();
            b.Height = 40;
            b.Length = 60;
            b.Width = 20;

            b.CalculateVolume();

            b.CalculateSurface();

            b.PrintInfo();
        }
    }
}
