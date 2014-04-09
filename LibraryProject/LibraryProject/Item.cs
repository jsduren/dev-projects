//Item Class
using System;

class Item 
{
	//maybe put different types of items as a category as a private 
	private string title;
	private string whoCheckedOut;
	private bool checkout = false;
	public DateTime checkDate;
    public DateTime dueDate; //I added this so I could compare the dates. -Brad

    public bool checkOutState; //Added this so I could test for current checkout state -Josh


	public Item(string _title, bool check, string _who = "", DateTime _checkDate = DateTime.Now)
	{
		checkedout = check;
		title = _title;
		whoCheckedOut = _who;
		checkDate = _checkDate;
	}
    // added the function brackets to be able to compile program. -Josh
    public virtual void checkout(){}

    // added the function brackets to be able to compile program. -Josh
    public void checkin()
    {
	}

    // added the function brackets to be able to compile program. -Josh
    public virtual int days()
    {
    }
	
	public bool isCheckedOut(){}
}

//child Book
class ChildBook: Item
{
	private static const int MAX = 7; //1 week 
	public override void checkout(){}
	public override int days() {	return MAX;	}
	ChildBook():Item{}
}

//Adult Book
class AdultBook: Item
{
	private static const int MAX = 14; //2 weeks
	public override void checkout(){}
	public override int days()
    {
		return MAX;
	}
	public AdultBook():Item{}
}

//Dvd
class DVD: Item 
{
	private static const int MAX = 2;
	public override void checkout(){}
	public override int days()
    {
		return MAX;
	}
	public DVD():Item{}
}

//Vhs
class VHS: Item
{
	private static const int MAX = 3; 
	public override void checkout(){}
	public override int days()
    {
		return MAX;
	}
	public VHS():Item{}
}