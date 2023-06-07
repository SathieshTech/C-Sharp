using System;
/*
 title :
 example for 'public' access specifier (or modifier)
 */
namespace satprj.access_specifier
{
    public class CLSASea
    {
        public int x;
    }
    class CLSASeb : CLSASea
    {
        public void showData()
        {
            Console.WriteLine(x);
        }
    }

    class CLSASec
    {
        public static void Main()
        {
            CLSASeb eb = new CLSASeb();
            eb.showData();
            Console.WriteLine(eb.x);
        }
    }
}

/*
 0
 0
 */
