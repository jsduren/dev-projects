//Patron class
public class Patron
{
	private string first;
	private string last;
	
    //I added the void return type to be able to compile. Change as needed -Brad
    public void displayName()
    {

    }

    //I added the void return type to be able to compile. Change as needed -Brad
    // Completed the virtual class to be able to compile program. -Josh
	public virtual void displayItems()
	{
	    throw new System.NotImplementedException();
	}

    //I added the void return type to be able to compile. Change as needed -Brad
    // Completed the virtual class to be able to compile program. -Josh
    public virtual void checkout()
    {
        throw new System.NotImplementedException();
    }

    //I added the void return type to be able to compile. Change as needed -Brad
    // Completed the virtual class to be able to compile program. -Josh
    public virtual void checkin()
    {
        throw new System.NotImplementedException();
    }
}

//Child class
public class Child : Patron
{
	public const int MAX_ITEMS = 3;
	//array to hold books max == 3

    // Completed the override class to be able to compile program. -Josh
    public override void checkout()
    {
        
    }

    // Completed the override class to be able to compile program. -Josh
    public override void checkin()
    {
        
    }

    // Completed the override class to be able to compile program. -Josh
    public override void displayItems()
    {
        
    }
}

//Adult class
class Adult : Patron
{
	public const int MAX_ITEMS = 6;
	//array to hold items, max is 6

    // Completed the override class to be able to compile program. -Josh
    public override void checkout()
    {

    }

    // Completed the override class to be able to compile program. -Josh
    public override void checkin()
    {

    }

    // Completed the override class to be able to compile program. -Josh
    public override void displayItems()
    {

    }
}