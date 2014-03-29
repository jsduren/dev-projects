//Item Class
using System;

class Item 
{
	private string title;
	private string whoCheckedOut;
    public DateTime dueDate; //I added this so I could compare the dates. -Brad
	//timestamp of check out date
	//due date 
	
	public void checkout();
	public void checkin();
	public void days();
}

//child Book
class ChildBook: Item
{

}

//Adult Book
class AdultBook: Item
{

}

//Dvd
class DVD: Item 
{

}

//Vhs
class VHS: Item
{

}