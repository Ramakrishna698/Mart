namespace FP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            long num, temp;
            int a, c, e, n, m, count = 0, sp, spa, l, price = 0, ch, ct = 0, ch1, ct0, ct1, ct2 = 0, ct3 = 0, count1;
            int[] r = new int[100];
            int[] cost = new int[100];
            int[] unit = new int[100];
            string[] t = new string[100];
            string[] item = new string[100];
            string un = "admin", pw = "admin", d, f, mail, name, any;
            Console.WriteLine("\n\t\t\t\t\t\t\t\t\tWELCOME TO MY Mart");
            Y: Console.WriteLine("\n\nSELECT USER TYPE\n");
            Console.WriteLine("1.ADMIN\n2.USER\n3.EXIT");
            Console.Write("\nEnter Your Option: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                Console.Clear();
                Console.WriteLine("\t\tWelcome to Admin Login page\n");
                Console.WriteLine("Your Username: " + un + "\nYour Password: " + pw);
                Console.WriteLine("\nDo you want to change your password: ");
                Console.WriteLine("1.Yes\n2.No");
                c = Convert.ToInt32(Console.ReadLine());
                G: Console.WriteLine();
                if (c == 1)
                {
                    Console.Write("Enter new password: ");
                    d = Console.ReadLine();
                    pw = d;
                    Console.WriteLine("\nPassword was successfully updated\n");
                    X: Console.WriteLine("Do you want to Login?");
                    Console.WriteLine("1.Yes\n2.No");
                    e = Convert.ToInt32(Console.ReadLine());
                    if (e == 1)
                    {
                        c = 2;
                        goto G;
                    }
                    else if (e == 2)
                    {
                        Console.Clear();
                        goto Y;
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid number[1/2]\n");
                        goto X;
                    }
                }
                else if (c == 2)
                {
                    B: Console.Write("Please enter your password to Login: ");
                    f = Console.ReadLine();
                    if (f == pw)
                    {
                        Console.WriteLine("\nLogin Successful\n\nPlease wait\n");
                        Console.Write("Moving to Dashboard");
                        for(int i = 0; i < 3; i++)
                        {
                            Console.Write(".");
                            Thread.Sleep(1000);
                        }
                        Console.Clear();
                        Console.WriteLine("Welcome to Dashboard\n\n");
                        Console.Write("Enter no of items: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        H: Console.WriteLine();
                        ct1 = n + ct2;
                        for (int i = ct3; i < ct1; i++)
                        {
                            o: Console.Write("Enter item " + (i + 1) + " : ");
                            w: t[i] = Console.ReadLine();
                            for (int k = 0; k < i; k++)
                            {
                                if (t[i] == t[k])
                                {
                                    Console.WriteLine("You have already entered the item!");
                                    Console.Write("Would you like to change the cost of the item[1/0]: ");
                                    ch = Convert.ToInt32(Console.ReadLine());
                                    if (ch == 0)
                                    {
                                        Console.Write("Please Enter another item: ");
                                        goto w;
                                    }
                                    else
                                    {
                                        Console.Write("Enter the cost of " + t[k] + " : ");
                                        cost[k] = Convert.ToInt32(Console.ReadLine());
                                        goto o;
                                    }
                                }
                            }
                            Console.Write("Enter the cost of " + t[i] + " : ");
                            cost[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine();
                        Console.Write("\nWould U like to enter more items[1/0]: ");
                        I: ch1 = Convert.ToInt32(Console.ReadLine());
                        if (ch1 == 0)
                        {
                            Console.WriteLine("\n     Item      |      Cost     ");
                            Console.WriteLine("---------------|---------------");
                            for (int i = 0; i < ct1; i++)
                            {
                                sp = 15 - t[i].Length;
                                Console.Write(t[i]);
                                for (int j = 0; j < sp; j++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write("|");
                                Console.WriteLine("           " + cost[i]);
                            }
                            Console.Write("\n\nPress enter to move to Mainmenu...");
                            any = Console.ReadLine();
                            if (true)
                            {
                                Console.Write("\nMoving to Mainmenu");
                                for (int i = 0; i < 3; i++)
                                {
                                    Console.Write(".");
                                    Thread.Sleep(1000);
                                }
                            }
                        }
                        else if (ch1 == 1)
                        {
                            Console.Write("\nEnter how many items U want to add extra: ");
                            ct0 = Convert.ToInt32(Console.ReadLine());
                            ct2 = ct2 + ct0;
                            ct3 = ct1;
                            goto H;
                        }
                        else
                        {
                            Console.Write("Please enter a valid option[1/0]: ");
                            goto I;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Password");
                        goto B;
                    }
                }
                Console.Clear();
                goto Y;
            }
            else if (a == 2)
            {
                Console.Clear();
                Console.WriteLine("\t\tWelcome to User Page \n\n");
                Console.WriteLine("Items available in the mart\n");
                Console.WriteLine("     Item      |      Cost");
                Console.WriteLine("---------------|---------------");
                if (t[0] == null)
                {
                    string[] h = { "milk", "biscuit", "bread", "jam", "eggs", "drinks" };
                    int[] g = { 10, 20, 10, 25, 10, 25 };
                    for (int i = 0; i < 6; i++)
                    {
                        t[i] = h[i];
                        cost[i] = g[i];
                    }
                }
                for (int i = 0; i < 100; i++)
                {
                    if (t[i] == null)
                    {
                        break;
                    }
                    count++;
                    l = 15 - t[i].Length;
                    Console.Write(t[i]);
                    for (int j = 0; j < l; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("|");
                    Console.WriteLine("           " + cost[i]);
                }
                P: Console.Write("\nEnter no of items you want: ");
                m = Convert.ToInt32(Console.ReadLine());
                if (m > count)
                {
                    Console.WriteLine("You have exceeded the available products");
                    Console.WriteLine("Please enter between 1 and " + count);
                    goto P;
                }
                count1 = count - m;
                ct2 = 0;
                ct1 = m;
                ct3 = 0;
                h: Console.WriteLine();
                for (int i = ct3;i < ct1; i++)
                {
                    O: Console.Write("Enter your "+(i+1)+" item: ");
                    W: item[i] = Console.ReadLine();
                    int av = 0;
                    for (int j = 0;j < count; j++)
                    {
                        if (item[i] == t[j])
                        {
                            av = 1;
                            break;
                        }
                    }
                    if(av == 0)
                    {
                        Console.WriteLine("Sorry! Item not available");
                        Console.WriteLine("Please Re-enter");
                        goto O;
                    }
                    for (int k = 0; k < i; k++)
                    {
                        if (item[i] == item[k])
                        {
                            Console.WriteLine("Sorry! You have already entered it");
                            Console.Write("Would you like to change the quantity[0/1]: ");
                            ch=Convert.ToInt32(Console.ReadLine());
                            if (ch == 0)
                            {
                                Console.Write("Please Enter another item: ");
                                goto W;
                            }
                            else
                            {
                                Console.Write("Enter no of units: ");
                                unit[k]=Convert.ToInt32(Console.ReadLine());
                                goto O;
                            }
                        }
                    }
                    Console.Write("No of units you want: ");
                    unit[i]= Convert.ToInt32(Console.ReadLine());
                }
                count1 = count1 - ct2;
                if (count1 != 0)
                {
                    Console.Write("\nWould U like to enter more items to cart[1/0]: ");
                    J: ch1 = Convert.ToInt32(Console.ReadLine());
                    if (ch1 == 1 || ch1 == 0)
                    {
                        if (ch1 == 1)
                        {
                            Console.WriteLine();
                            Console.Write("Enter how many items U want to add extra: ");
                        q: ct2 = Convert.ToInt32(Console.ReadLine());
                            ct3 = ct1;
                            ct1 = ct1 + ct2;
                            if (ct1 > count)
                            {
                                Console.WriteLine();
                                ct1 = ct1 - ct2;
                                Console.WriteLine("You have exceeded the available products\n");
                                Console.Write("Please enter again: ");
                                goto q;
                            }
                            else
                            {
                                goto h;
                            }
                        }
                    }
                    else
                    {
                        Console.Write("Please enter a valid option[1/0]: ");
                        goto J;
                    }
                }
                for (int i = 0;i<ct1; i++)
                {
                    for (int j = 0; j < count; j++)
                    {
                        if (item[i] == t[j])
                        {
                            r[i] = unit[i] * cost[j];
                            price = price + r[i];
                            break;
                        }
                    }
                }
                Console.Write("\nMoving to Billing");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                Console.Clear();
                Console.WriteLine("\nPlease fill the below details for billing");
                Console.Write("\nPlease Enter your name: ");
                name= Console.ReadLine();
                Console.Write("\nPlease Enter your Mobile Number: +91 ");
                Q: num=Convert.ToInt64(Console.ReadLine());
                temp = num;
                while (temp != 0)
                {
                    temp = temp / 10;
                    ct++;
                }
                if (ct != 10)
                {
                    Console.Write("\nMobile Number is not valid");
                    Console.Write("Please Re-Enter your Mobile Number: ");
                    ct = 0;
                    goto Q;
                }
                Console.Write("\nPlease Enter your Email-ID: ");
                mail = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\n                     BILL PAYMENT\n");
                Console.WriteLine("User ID               :   " + (name.Substring(0, 2).ToUpper() + num % 10000) + "\n\n");
                Console.WriteLine("     Item      |    Units    |    Cost");
                Console.WriteLine("---------------|-------------|--------");
                for (int i = 0; i < ct1; i++)
                {
                    sp = 15 - item[i].Length;
                    Console.Write(item[i]);
                    for (int j = 0; j < sp; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("|");
                    Console.Write("      " + unit[i]);
                    spa = 7 - unit[i].ToString().Length;
                    for(int w = 0; w < spa; w++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("|    " + r[i]);
                }
                Console.WriteLine("---------------|-------------|--------");
                Console.WriteLine("                  TOTAL BILL | Rs."+price);
                Console.WriteLine("\t\tKINDLY PAY THE BILL AMOUNT\n\n");
            }
            else if (a == 3)
            {
                Console.Write("\n\nExiting");
                for(int i = 0; i < 3; i++)
                {
                    Thread.Sleep(1000);
                    Console.Write(".");
                }
            }
            else
            {
                Console.WriteLine("Please enter valid number\n");
                goto Y;
            }
        }
    }
}