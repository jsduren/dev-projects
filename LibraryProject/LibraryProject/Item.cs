//Item Class...
using System;

class Item 
{
	private string title;
	private string whoCheckedOut;
    public DateTime dueDate; //I added this so I could compare the dates. -Brad
	//timestamp of check out date
	//due date 

    // added the function brackets to be able to compile program. -Josh
    public void checkout()
    {
    }

    // added the function brackets to be able to compile program. -Josh
    public void checkin()
    {
    }

    // added the function brackets to be able to compile program. -Josh
    public void days()
    {
    }
}

//child Book
class ChildBook: Item
{
	private static const int MAX = 7; //1 week 
}

//Adult Book
class AdultBook: Item
{
	private static const int MAX = 14; //2 weeks
}

//Dvd
class DVD: Item 
{
	private static const int MAX = 2; 
}

//Vhs
class VHS: Item
{
	private static const int MAX = 3; 
}