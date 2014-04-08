//Item Class
using System;

class Item 
{
	private string title;
	private string whoCheckedOut;
    public DateTime dueDate; //I added this so I could compare the dates. -Brad
    public bool checkOutState; //Added this so I could test for current checkout state -Josh
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