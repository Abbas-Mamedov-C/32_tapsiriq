namespace tapsiriq19;
class ATM
{
    private double _balans;

    public ATM(double start_balans)
    {
        _balans = start_balans;
        print_menu();

    }

    public void atm_start()
    {
        char option;
        bool exit = false;
        while (!exit)
        {

            Console.Write("$");
            option = char.Parse(Console.ReadLine());
            
            switch (option)
            {
                case '1': show_balance(); break;
                case '2': withdraw(); break;
                case '3': deposit(); break;
                case '0': exit = true; break;
                default: 
                    Console.WriteLine("Bilinmeyen parametr daxil edildi!\n Bir daha sinayin"); 
                    break;
            }
        }

        Console.WriteLine("Goodbye :)\n");

    }

    private void withdraw()
    {
        Console.WriteLine("Mebleg daxil edin");

        double miqdar;
        miqdar = Convert.ToDouble(Console.ReadLine());

        if (_balans < miqdar)
        {
            Console.WriteLine($"{miqdar} mebleg balansdan coxdur!");
            return;
        }
        else if (miqdar < 0)
        {
            Console.WriteLine("Menfi mebleg daxil edile bilmez!");
        }

        _balans -= miqdar;

        Console.WriteLine($"{miqdar} manat pul cixarildi.");
    }

    private void deposit()
    {
        Console.WriteLine("Mebleg daxil edin");

        double miqdar;
        miqdar = Convert.ToDouble(Console.ReadLine());

        if (miqdar < 0)
        {
            Console.WriteLine("Menfi mebleg daxil edile bilmez!");
        }

        _balans += miqdar;

        Console.WriteLine($"{miqdar} manat pul balansa elave edildi.");
    }

    private void show_balance()
    {
        Console.WriteLine("Balans: " + _balans);
    }

    private void print_menu()
    {
        Console.WriteLine(
        "///MAIN MENU OPTIONS:              ///\n"+
        "/// Write \"1\" to show your balance ///\n"+
        "/// Write \"2\" to withdraw money    ///\n"+
        "/// Write \"3\" to deposit money     ///\n"+
        "/// Write \"0\" to EXIT              ///"
        );
    }

}