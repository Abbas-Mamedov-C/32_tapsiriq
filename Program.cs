using System;

using tapsiriq19;
using GalleryNS;
using System.Security.Cryptography;


class myClass
{
    static void Main2()
    {

        Gallery GALLERY = new Gallery();

        char option;
        while (true)
        {
            Gallery.print_menu();

            Console.Write("secimi daxil edin $");
            option = char.Parse(Console.ReadLine());

            switch (option)
            {
                case '1': GALLERY.Addcar(); break;

                case '2': GALLERY.print_cars(); break;

                case '3':
                    if (GALLERY.Car_count == 0)
                    {
                        Console.WriteLine("\nGalleride masin yoxdur!\n");
                        break;
                    }
                    Console.WriteLine(
                        "\n  1.Brand adına gore axtarmaq\n" +
                        "  2.Mile gore axtarmaq\n"
                        );

                    Console.Write("  secimi daxil edin $");
                    option = char.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case '1':
                            Console.Write("  Brand adi: ");
                            GALLERY.FilterCar(
                                Console.ReadLine()
                            );
                            break;

                        case '2':
                            Console.Write("  Mile: ");
                            GALLERY.FilterCar(
                                double.Parse(Console.ReadLine())
                            );
                            break;
                    }
                    break;

                case '0':

                    return;
                    break; // bu break-in cox xeyri olacaq ;)

                default:
                    Console.WriteLine("Bele bir option yoxdur");
                    break;
            }

        }




    }


    static void Main()
    {
        t32();
    }

    static void t1()
    {
        int a = 0, b = 0;
        Console.WriteLine("a+b=" + a + b);
    }
    static void t2()
    {
        int a = 9;
        Console.WriteLine("a^2=" + a * a);
    }
    static void t3()
    {
        string ad = "Abbas";
        int yas = 20;

        Console.WriteLine($"{ad} {yas}");
    }
    static void t4()
    {
        int a = 13, b = 21;
        Console.WriteLine($"evvel a={a}, b={b}");

        a += b;
        b = a - b;
        a -= b;

        Console.WriteLine($"sonra a={a}, b={b}");
    }
    static void t5()
    {

        int a, b, c;
        Console.Write("input a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("input b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("input c: ");
        c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("ededi orta= " + ((float)(a + b + c)) / 3);
        Console.WriteLine("cem= " + (a + b + c));

    }
    static void t6()
    {

        Console.Write("4 reqemli eded yazin: ");

        int n = Convert.ToInt32(Console.ReadLine());
        int cem = 0;

        while (n != 0)
        {
            cem += n % 10;
            n /= 10;
        }

        Console.WriteLine("cem=" + cem);

    }
    static void t7()
    {
        Console.Write("eded daxil edin: ");

        int n = Convert.ToInt32(Console.ReadLine());

        if (n % 2 != 0)
        {
            Console.WriteLine("tek eded");
        }
        else
        {
            Console.WriteLine("cut eded");
        }
    }
    static void t8()
    {

        int n, i;
        Console.Write("num1 = ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("num2 = ");
        i = Convert.ToInt32(Console.ReadLine());
        if (n < i)
        {
            Console.WriteLine($"{n}<{i}");
        }
        else if (n > i)
        {
            Console.WriteLine($"{n}>{i}");
        }
        else
        {
            Console.WriteLine($"{n}={i}");
        }
    }
    static void t9()
    {
        int i;
        Console.Write("num = ");
        i = Convert.ToInt32(Console.ReadLine());

        if (i < 0)
        {
            Console.WriteLine($"menfi eded");
        }
        else if (i > 0)
        {
            Console.WriteLine("musbet eded");
        }
        else
        {
            Console.WriteLine("eded 0");
        }
    }
    static void t10()
    {
        Console.Write("eded daxil edin: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num % 3 == 0 && num % 5 == 0)
        {
            Console.WriteLine("Bolunur\n");
        }
        else
        {
            Console.WriteLine("Bolunmur");
        }
    }
    static void t11()
    {
        Console.Write("eded daxil edin: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num % 3 == 0 && num % 2 == 0)
        {
            Console.WriteLine("Bolunur\n");
        }
        else
        {
            Console.WriteLine("Bolunmur");
        }
    }
    static void t12()
    {
        Console.Write("ayin nomresi: ");
        int n = Convert.ToInt32(Console.ReadLine());

        switch (n)
        {
            case 1: Console.WriteLine("Yanvar"); break;
            case 2: Console.WriteLine("Fevral"); break;
            case 3: Console.WriteLine("Mart"); break;
            case 4: Console.WriteLine("Aprel"); break;
            case 5: Console.WriteLine("May"); break;
            case 6: Console.WriteLine("İyun"); break;
            case 7: Console.WriteLine("İyul"); break;
            case 8: Console.WriteLine("Avqust"); break;
            case 9: Console.WriteLine("Sentyabr"); break;
            case 10: Console.WriteLine("Oktyabr"); break;
            case 11: Console.WriteLine("Noyabr"); break;
            case 12: Console.WriteLine("Dekabr"); break;
            default: Console.WriteLine("Yanlış ay nömrəsi!"); break;
        }
    }
    static void t13()
    {
        Console.Write("bal daxil edin: ");
        int n = int.Parse(Console.ReadLine());
        if (n >= 90)
        {
            Console.WriteLine("A+");
        }
        else if (n >= 80)
        {
            Console.WriteLine("A");
        }
        else if (n >= 70)
        {
            Console.WriteLine("B");
        }
        else if (n >= 50)
        {
            Console.WriteLine("C");
        }
        else if (n >= 35)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F :(");
        }

    }
    static void t14()
    {
        Console.Write("num1=");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("num2=");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("operator sec /,*,+,-: ");
        char opt = char.Parse(Console.ReadLine());

        switch (opt)
        {
            case '/': Console.WriteLine(((float)num1) / num2); break;
            case '*': Console.WriteLine(num1 * num2); break;
            case '-': Console.WriteLine(num1 - num2); break;
            case '+': Console.WriteLine(num1 + num2); break;
        }

    }
    static void t15()
    {
        Console.WriteLine("endirim elde etmek ucun mebleg yazin");
        Console.Write("mebleg:");
        float n = float.Parse(Console.ReadLine());
        if (n > 99f)
        {
            Console.WriteLine($"size 10%~{n / 100 * 10}AZN endirim!!");
        }
        else if (n >= 50f)
        {
            Console.WriteLine($"size 5%~{n / 100 * 5}AZN endirim!!");
        }
        else if (n < 50f)
        {
            Console.WriteLine($"size 0%~0AZN endirim!! >:D");
        }
    }
    static void t16()
    {

        string usr, pass;
        Console.Write("Login\nUsername: ");
        usr = Console.ReadLine();

        Console.WriteLine("Password: ");
        pass = Console.ReadLine();

        if ((usr == "admin") && (pass == "2222"))
        {
            Console.WriteLine("Welcome!");
        }
        else
        {
            Console.WriteLine("Username ve ya Password yanlisdir");
        }
    }
    static void t17()
    {
        const double usd_as_azn = 1.71;
        double mebleg;

        Console.WriteLine("money converter");
        Console.WriteLine("AZN -> USD ucun 1 yaz\nUSD -> AZN ucun 2 yaz");

        char opt = char.Parse(Console.ReadLine());

        Console.Write("Meblegi daxil edin: ");
        mebleg = Convert.ToDouble(Console.ReadLine());

        switch (opt)
        {
            case '1':
                Console.WriteLine($"{mebleg}AZN -> {mebleg / usd_as_azn}USD");
                break;
            case '2':
                Console.WriteLine($"{mebleg}USD -> {mebleg * usd_as_azn}AZN");
                break;
            default:
                Console.WriteLine("bilinmeyen option!");
                break;
        }
    }
    static void t18()
    {

        float m;
        float h;

        Console.Write("Ceki daxil edin: ");
        m = float.Parse(Console.ReadLine());

        Console.Write("Boy daxil edin: ");
        h = float.Parse(Console.ReadLine());

        float BMI = m / (h * h);

        Console.WriteLine($"BMI: {BMI}");

        if (BMI < 18.5f)
        {
            Console.WriteLine("Çəki azlığı");
        }
        else if (BMI <= 24.9f)
        {
            Console.WriteLine("Normal çəki");
        }
        else if (BMI <= 29.9f)
        {
            Console.WriteLine("Artıq çəki");
        }
        else
        {
            Console.WriteLine("Piylənmə");
        }


    }
    static void t19()
    {

        tapsiriq19.ATM ATM = new tapsiriq19.ATM(120000);

        ATM.atm_start();

    }
    static void t20()
    {
        int[] arr = new int[5] { 1, 2, 3, 4, 5 };

        Console.Write("arr[5] elementleri-> ");
        foreach (var a in arr)
        {
            Console.Write(a + " ");
        }
        Console.WriteLine();
    }
    static void t21()
    {
        int[] arr = new int[5] { 1, 2, 3, 4, 5 };
        int sum = 0;
        Console.Write("arr[5] elementlerinin cemi-> ");
        foreach (var a in arr)
        {
            sum += a;
        }
        Console.WriteLine(sum);
    }
    static void t22()
    {
        int[] arr = new int[5] { 1, 2, 3, 4, 5 };
        double sum = 0;
        Console.Write("arr[5] elementlerinin ededi ortasi-> ");
        foreach (var a in arr)
        {
            sum += a;
        }
        Console.WriteLine(sum / 5);
    }
    static void t23()
    {
        int[] arr = new int[5] { 1, 2, 3, 4, 5 };
        int min = arr[3], index = -1;

        for (int index_ = 0; index_ < arr.Length; index_++)
        {
            if (min < arr[index_]) { min = arr[index_]; index = index_; }
        }
        Console.WriteLine($"arr[5] massivinde en kicik elementi: {min}, index: {index}");

    }
    static void t24()
    {
        int[] arr = new int[7] { 12, 3, 543, 23, 87, 66, -6 };

        Console.Write("arr[7] massivinin cut elementleri-> ");
        foreach (var a in arr)
        {
            if (a % 2 == 0) { Console.Write(a + " "); }
        }
        Console.WriteLine();
    }
    static void t25()
    {

    }
    static void t26()
    {
        int[] sorted_array = { 1,1,1, 2, 2, 3, 4, 5, 6, 6, 6, 7, 8, 8, 8,33,33 };
        // cox yuksek seviyyede xais edilir ki INPUT OLARAQ SORTED ARRAY VERINNNNN!!
        int[] clone_array = new int[sorted_array.Length/2+1];
        int clone_cursor = 0; 
        int cursor = 1;
        foreach( int target in sorted_array ){

            int low = cursor;
            int high = sorted_array.Length - 1;
            while(low <= high){
                
                int mid = low + (high - low)/2;

                if(target > sorted_array[mid]) { low = mid + 1; }
                else if (target < sorted_array[mid]) { high = mid - 1; }     
                else {
                    int t = 0; bool is_exists = false;
                    do{
                        if(clone_array[t] == target){is_exists=true;}
                        t++;
                    }while(t<clone_cursor);
                    if(!is_exists){clone_array[clone_cursor]=target;clone_cursor++;}
                    break;
                }
            }
            cursor++;
        }// foreach

        for(int t=0; t<clone_cursor;t++){
            Console.WriteLine(clone_array[t]);
        }
    }
    static void t27()
    {
        int[] array = {1,2,3,4,5,6,7,8};
        int max=array[0], sec=array[0];

        foreach(int t in array){
            if(t>max){
                sec = max;
                max = t;
            }
        }
        Console.WriteLine(sec);
    }
    static void t28()
    {
        int t = 1234;
        int cem =0 ;
        while(t!=0){
            cem+=t%10;
            t/=10;
        }
        Console.WriteLine(cem);
    }
    static void t29()
    {
        int t = 1234;
        int cem=0,say=0;

        while(t!=0){
            cem+=t%10;
            t/=10;
            say++;
        }
        Console.WriteLine($"Cem: {cem}, say: {say}");
    }
    static void t30()
    {
        int t = 1234;
        int say=0;

        while(t!=0){

            t/=10;
            say++;
        }
        Console.WriteLine($"say: {say}");
    }
    static void t31()
    {
        int num = 17;

        for(int bolen = 2; bolen < num/2; bolen++){
            if(num % bolen == 0){
                Console.WriteLine($"{num }is not prime");
                return;
            }
        }
        Console.WriteLine($"{num} is prime");
    }
    static void t32(){

        string str = "123321";
        int f=0,b=str.Length-1; 
        while(f<b)
        {
            if (str[b] == str[f]) 
            {
                b--;++f;
                continue; 
            }
            Console.WriteLine("polindrom deyil");
            return;
        }
        Console.WriteLine("polindromdur");
    }

}

