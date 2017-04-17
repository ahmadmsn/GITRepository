using System;
public class Bill_Details
{
	public string inv_number;
	public string ord_date;
	public string cust_name;
	public string product;
	public double cost;
	public double advance_amount;
	public double due_amount;
}
class structure
{
	public static void Main()
	{
		
		Bill_Details b=new Bill_Details();
		b.inv_number="A101";
		b.ord_date="10/10/06";
		b.cust_name="Adams";
		b.product="Petrol";
		b.cost=100;
		b.advance_amount=50;
		b.due_amount=50;
		Console.Clear();
		Console.WriteLine("Invoice Number Is {0}",b.inv_number);
		Console.WriteLine("Order Date Is {0}",b.ord_date);
		Console.WriteLine("Customer  Name Is {0}",b.cust_name);
		Console.WriteLine("Product Is {0}",b.product);
		Console.WriteLine("Cost Is {0}",b.cost);
		Console.WriteLine("Advance Amount Is {0}",b.advance_amount);
		Console.WriteLine("Due Amount Is {0}",b.due_amount);
		Console.ReadLine();
		
	}
}
		
	
