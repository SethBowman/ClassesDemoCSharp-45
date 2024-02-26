using ClassesDemoCSharp_45;

//Instance of the classroom class
var csharp45 = new Classroom();

//Instance of a class (object)

var seth = new Person();

csharp45.OurClass.Add(seth);

//Dot notation
seth.Name = "Seth";
seth.Age = 29;
seth.money = 20;

//Object initializer syntax
var mack = new Person() 
{ 
    Name = "Mack",
    Age = 24,
    money = 50
};

csharp45.OurClass.Add(mack);

//Using a custom constructor
var cruz = new Person("Cruz", 31);

csharp45.OurClass.Add(cruz);


csharp45.GreetEveryone();