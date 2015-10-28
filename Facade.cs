
//http://www.cnblogs.com/DylanWind/archive/2008/11/19/1336151.html
public class Mortgage
{
   private Bank bank = new Bank();
   private Loan loan = new Loan();

   private Credit credit = new Credit();

   public bool IsEligible(Customer customer,int amount)
   {
	Console.WriteLine("{0} applies for {1:c} loan\n",
	customer.Name,amount);

	bool eligible = true;

	if(!bank.HasSufficientSavings(customer,amount))
	{
		eligible =false;
	}
	else if(!loan.HasNoBadLoans(customer))
	{
		eligible =false;
	}
	else if(!credit.HasGoodCredit(customer))
	{
		eligible =false;
	}

	return eligible;
   
   }
}

public class Bank
{
  public bool HasSufficientSavings(Customer c,int amount)
  {
	Console.WriteLine("Check bank for "+c.Name);
	return true;
  }
}

public class Credit
{
	public bool HasGoodCredit(Customer c)
	{
		Console.WriteLine("Check credit for"+ c.Name);
		return true;	
	}
}

public class Loan
{
    public bool HasNoBadLoans(Customer c)
    {
	Console.WriteLine("Check loans for"+c.Name);
	return true;
    }
}

public class Customer
{
   private string name;

   public Customer(string name)
   {
	this.name =name;
   }

   public string Name
   {
	get { return name;}
   }
}

public class MainApp
{
    public static void Main()
    {
	Mortage mortage = new Mortage();

	Customer customer = new Customer("ss");

	bool eligable = mortgage.IsEligible(customer);

	Console.WriteLine("\n" + customer.Name+
	"has been "+ (eligable ? "Approved" : "Rejected");

	Console.ReadLine();
    }
}