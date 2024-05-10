using System.Runtime.InteropServices;

namespace ConsoleApp3
{
    internal class Program
    {
        [DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hWnd);



        static void Main(string[] args)
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            int horzRes = GetDeviceCaps(hdc, 118); 
            int vertRes = GetDeviceCaps(hdc, 117); 
            double diagonalInPixels = Math.Sqrt(Math.Pow(horzRes, 2) + Math.Pow(vertRes, 2));
            
            
            // Предполагаем, что типичное разрешение монитора 96 dpi
            double diagonalInInches = diagonalInPixels / 96;
            Console.WriteLine("Диагональ монитора: " + diagonalInInches.ToString("F2") + " дюймов");
        }
    }
}
