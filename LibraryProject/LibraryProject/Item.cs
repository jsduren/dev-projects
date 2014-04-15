//Item Class
using System;

public class Item 
{
	//maybe put different types of items as a category as a private 
	public string title;
	public string whoCheckedOut;
	public bool checkedout;
	public DateTime checkDate;
    public DateTime dueDate; //I added this so I could compare the dates. -Brad

    public Item()
    {
        title = "";
        whoCheckedOut = "";
        checkedout = false;
        checkDate = DateTime.Now;
        dueDate = DateTime.Now;
    }
	public Item(string _title, bool check, string _who, DateTime _checkDate, DateTime _dueDate)
	{
		checkedout = check;
		title = _title;
		whoCheckedOut = _who;
		checkDate = _checkDate;
		dueDate = _dueDate;
	}
    // added the function brackets to be able to compile program. -Josh
    public virtual void checkout(string _who){}
    // added the function brackets to be able to compile program. -Josh
    public void checkin()
	{
		whoCheckedOut = "";
		checkedout = false;
	}
	public bool isCheckedOut(){ return checkedout; }
    public virtual int maxDays()
    {
        return 0;
    }
}

//child Book
class ChildBook: Item
{
	private const int MAX = 7; //1 week 
	public override void checkout(string _who)
	{
		whoCheckedOut = _who;
		checkDate = LibraryProject.LibraryForm.curDateTime;
		dueDate = checkDate.AddDays(MAX);
		checkedout = true;
	}
	public ChildBook(string _title, bool check, string _who, DateTime _checkDate, DateTime _dueDate):base(_title, check, _who, _checkDate, _dueDate){}

    public override int maxDays()
    {
        return MAX;
    }
}

//Adult Book
class AdultBook: Item
{
	private const int MAX = 14; // 2 weeks
	public override void checkout(string _who)
	{
		whoCheckedOut = _who;
        checkDate = LibraryProject.LibraryForm.curDateTime;
		dueDate = checkDate.AddDays(MAX);
		checkedout = true;
	}
    public AdultBook() : base() { }
	public AdultBook(string _title, bool check, string _who, DateTime _checkDate, DateTime _dueDate):base(_title, check, _who, _checkDate, _dueDate){}

    public override int maxDays()
    {
        return MAX;
    }
}

//Dvd
class DVD: Item 
{
	private const int MAX = 2;
	public override void checkout(string _who)
	{
		whoCheckedOut = _who;
        checkDate = LibraryProject.LibraryForm.curDateTime;
		dueDate = checkDate.AddDays(MAX);
		checkedout = true;
	}
	public DVD(string _title, bool check, string _who, DateTime _checkDate, DateTime _dueDate):base(_title, check, _who, _checkDate, _dueDate){}

    public override int maxDays()
    {
        return MAX;
    }
}

//Vhs
class VHS: Item
{
	private const int MAX = 3; 
	public override void checkout(string _who)
	{
		whoCheckedOut = _who;
        checkDate = LibraryProject.LibraryForm.curDateTime;
		dueDate = checkDate.AddDays(MAX);
		checkedout = true;
	}
	public VHS(string _title, bool check, string _who, DateTime _checkDate, DateTime _dueDate):base(_title, check, _who, _checkDate, _dueDate){}

    public override int maxDays()
    {
        return MAX;
    }
}