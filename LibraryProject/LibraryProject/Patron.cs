//Patron class
public class Patron
{
	private string first;
	private string last;
	public int numberofItems;
	
    public Patron(string _first, string _last, int _numberofItems = 0)
	{
		first = _first;
		last = _last;
		numberofItems = _numberofItems;
	}
	//I added the void return type to be able to compile. Change as needed -Brad
    public string displayName()
    {
		return first + " " + last; 
    }

    //I added the void return type to be able to compile. Change as needed -Brad
    // Completed the virtual class to be able to compile program. -Josh
	public virtual void displayItems()
	{
	    throw new System.NotImplementedException();
	}

    //I added the void return type to be able to compile. Change as needed -Brad
    // Completed the virtual class to be able to compile program. -Josh
    public virtual bool checkout(ref Item current)
    {
        throw new System.NotImplementedException();
    }

    //I added the void return type to be able to compile. Change as needed -Brad
    // Completed the virtual class to be able to compile program. -Josh
    public virtual void checkin(ref Item current)
    {
        throw new System.NotImplementedException();
    }
}

//Child class
public class Child : Patron
{
	private const int MAX = 3;	
	public Child(string _first, string _last, int _numberofItems):base(_first, _last, _numberofItems)
	{
	
	}

    // Completed the override class to be able to compile program. -Josh
    public override bool checkout(ref Item current) //pass an item as a ref and return a bool 
    {
        //checks the type

		if(Item is ChildBook && numberofItems < MAX)//**************************Fix!!!!!!!!!!!!!!!!!!1

		if(current is ChildBook || numberofItems == MAX)
<<<<<<< HEAD
=======

>>>>>>> 2c97a88d6e25389fb69e8044d28780edb96b9400
		{
			current.checkout(this.displayname());
			++numberofItems;
			return true;
		}
		//if ok call check out of item
		else if(numberofItems == MAX)
		{
			return false; 
		}
		else 
		{
<<<<<<< HEAD
=======

>>>>>>> 2c97a88d6e25389fb69e8044d28780edb96b9400
			throw new System.ArgumentException("Item is not a child book...", "current");
			return false;
		}

            current.checkout(this.displayName());
            ++numberofItems;
            return true;
		}	
<<<<<<< HEAD
=======

>>>>>>> 2c97a88d6e25389fb69e8044d28780edb96b9400
    }

    public override void checkin(ref Item current) //pass by reference item
    {
		current.checkin();
		--numberofItems; 
    }
}

//Adult class
class Adult : Patron
{
	private const int MAX = 6;
	public Adult(string _first, string _last, int _numberofItems):base(_first, _last, _numberofItems)
	{
	
	}

    public override bool checkout(ref Item current) //pass an item as a ref and return a bool 
    {
        //checks the type
		if(numberofItems == MAX)
		{
			throw new System.ArgumentException("Patron has max # of checked out items...", "current");
			return false;
		}
		//if ok call check out of item
		else 
		{
			current.checkout(this.displayName());
			++numberofItems;
			return true;
		}
    }

    public override void checkin(ref Item current) //pass by reference item
    {
		current.checkin();
		--numberofItems; 
    }
}