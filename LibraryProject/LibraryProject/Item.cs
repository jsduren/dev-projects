//Item Class
using System;

class Item 
{
	//maybe put different types of items as a category as a private 
	public string title;
	public string whoCheckedOut;
	public bool checkout;
	public DateTime checkDate;
    public DateTime dueDate; //I added this so I could compare the dates. -Brad

	public Item(string _title, bool check = false, string _who = "", DateTime _checkDate = DateTime.Now)
	{
		checkedout = check;
		title = _title;
		whoCheckedOut = _who;
		checkDate = _checkDate;
	}
    // added the function brackets to be able to compile program. -Josh
    public virtual void checkout(string _who){}
    // added the function brackets to be able to compile program. -Josh
    public void checkin()
	{
		whoCheckedout = ""
		checkout = false;
	}
	public bool isCheckedOut(){ return checkout;}
}

//child Book
class ChildBook: Item
{
	private static const int MAX = 7; //1 week 
	public override void checkout(string _who)
	{
		whoCheckedOut = _who;
		checkDate = DateTime.Now;
		dueDate = checkDate.AddDays(MAX);
		checkout = true;
	}
	ChildBook():Item(string _title, bool check = false, string _who = "", DateTime _checkDate = DateTime.Now){}
}

//Adult Book
class AdultBook: Item
{
	private static const int MAX = 14; //2 weeks
	public override void checkout(string _who)
	{
		whoCheckedOut = _who;
		checkDate = DateTime.Now;
		dueDate = checkDate.AddDays(MAX);
		checkout = true;
	}
	public AdultBook():Item(string _title, bool check = false, string _who = "", DateTime _checkDate = DateTime.Now){}
}

//Dvd
class DVD: Item 
{
	private static const int MAX = 2;
	public override void checkout(string _who)
	{
		whoCheckedOut = _who;
		checkDate = DateTime.Now;
		dueDate = checkDate.AddDays(MAX);
		checkout = true;
	}
	public DVD():Item(string _title, bool check = false, string _who = "", DateTime _checkDate = DateTime.Now){}
}

//Vhs
class VHS: Item
{
	private static const int MAX = 3; 
	public override void checkout(string _who)
	{
		whoCheckedOut = _who;
		checkDate = DateTime.Now;
		dueDate = checkDate.AddDays(MAX);
		checkout = true;
	}
	public VHS():Item(string _title, bool check = false, string _who = "", DateTime _checkDate = DateTime.Now){}
}