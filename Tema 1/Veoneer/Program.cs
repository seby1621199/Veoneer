
class Tema1
{
    public static void Main()
    {
        #region Declaration of variables
        string fullName1 = string.Empty;
        string fullName2 = string.Empty;
        string lastName1 = string.Empty;
        string lastName2 = string.Empty;
        string[] orderlist;
        #endregion

        #region Reading
        Console.WriteLine("Name Person1:");
        fullName1 = Console.ReadLine();

        Console.WriteLine("Name Person2:");
        fullName2 = Console.ReadLine();
        #endregion

        #region Extract Lastname
        lastName1 = fullName1.Substring(0, fullName1.IndexOf(" "));
        lastName2 = fullName2.Substring(0, fullName2.IndexOf(" "));
        #endregion

        #region Compare
        if (lastName1.CompareTo(lastName2) < 0)
        {
            orderlist = new string[] { lastName1, lastName2 };
        }
        else
        {
            orderlist = new string[] { lastName2, lastName1 };
        }
        #endregion
        #region Display
        Console.WriteLine("Order: ");
        foreach (string order in orderlist)
        {
            Console.WriteLine(order);
        }
        #endregion


    }
}