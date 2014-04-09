//Item Class
using System;

class Item 
{
	//maybe put different types of items as a category as a private 
	public string title;
	public string whoCheckedOut;
	public bool checkedout;
	public DateTime checkDate;
    public DateTime dueDate; //I added this so I could compare the dates. -Brad

	public Item(string _title, bool check = false, string _who = "", DateTime _checkDate)
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
		whoCheckedOut = "";
		checkout = false;
	}
	public bool isCheckedOut(){ return checkedout; }
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
		checkedout = true;
	}
	ChildBook():Item(string _title, bool check = false, string _who = "", DateTime _checkDate){}
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
		checkedout = true;
	}
	public AdultBook():Item(string _title, bool check = false, string _who = "", DateTime _checkDate){}
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
		checkedout = true;
	}
	public DVD():Item(string _title, bool check = false, string _who = "", DateTime _checkDate){}
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
		checkedout = true;
	}
	public VHS():Item(string _title, bool check = false, string _who = "", DateTime _checkDate){}
}