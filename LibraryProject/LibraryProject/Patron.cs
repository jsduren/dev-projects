//Patron class
class Patron
{
	private string first;
	private string last;
	
    //I added the void return type to be able to compile. Change as needed
	public void displayName();
	public virtual void displayItems();
	public virtual void checkout();
	public virtual void checkin();
}

//Child class
class Child : Patron
{
	private static const int MAX_ITEMS = 3;
	//array to hold books max == 3
}

//Adult class
class Adult : Patron
{
	private static const int MAX_ITEMS = 6;
	//array to hold items, max is 6
}