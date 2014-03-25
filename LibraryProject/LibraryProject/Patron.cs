//Patron class
class Patron
{
	private string first;
	private string last;
	
}

//Child class
class Child: Patron
{
	private static const int MAX = 3;
	//array to hold books max == 3
}

//Adult class
class Adult : Patron
{
	private static const int MAX = 6;
	//array to hold items, max is 6
}