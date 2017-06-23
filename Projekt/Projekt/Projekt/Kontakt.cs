using System.Diagnostics;

namespace Projekt
{
    public static class Kontakt
    {
        public static void facebook()
        {
            Process.Start("https://www.facebook.com/MariuszBielecki0");
        }
        public static void mail()
        {
            Process.Start("mailto:maniekb12@gmail.com");
        }
        public static void strona()
        {
            Process.Start("http://piwnicaprogramisty.pl");

        }
    }
}
