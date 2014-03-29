//Item Class
class Item 
{
	private string title;
	private string whoCheckedOut;
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