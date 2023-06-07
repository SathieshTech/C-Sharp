using System;
/*
 title :
 example for 'protected' access specifier (or modifier)
 */
namespace satprj.access_specifier
{
    class CLSASda
    {
        protected int x;
    }

    class CLSASdb : CLSASda
    {
        public void showData()
        {
            Console.WriteLine(x);
        }
    }

    class CLSASdc
    {
        public static void Main()
        {
            CLSASdb db = new CLSASdb();

            db.showData();

            //console.writeline(db.x);
        }
    }
}