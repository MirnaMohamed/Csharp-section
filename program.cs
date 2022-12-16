using System;
namespace Program;

public class Person {
	public string Name;
	public int Age ;
	public Person (string name, int age){
		Name = name;
		Age = age;
	}
	public virtual void Print(){
		Console.WriteLine("My name is {0} and my age is {1}", Name, Age);
	}
} 
public class Student : Person{
	public int Year ;
	public float GPA ;
	public Student (string name, int age, int y, float g):base(name, age){
		Year = y;
		GPA =g;
	}
	public override void Print(){
		Console.WriteLine("My name is {0} and my GPA is {1}", Name, GPA);
	}
}

public class Staff: Person {
	public double Salary;
	public int JoinYear;
	public Staff (string name, int age, double salary, int jyear): base(name, age){
		Salary = salary;
		JoinYear = jyear;
	}
	public override void Print(){
		Console.WriteLine("My name is {0}, my age is {1}, and my salary is {2}", Name, Age, Salary);
	}
}

public class Database {
	private int currentIndex ;
	public Person[] People = new Person[50];
	public void AddStudent(Student student){
		People[currentIndex++] = student;
	}
	public void AddStaff(Staff staff){
		People[currentIndex++] = staff;
	}
	public void PrintAll(){
		for(int i=0; i< currentIndex; i++){
			People[i].Print();
	}	}
	public void AddPerson(Person person){
		People[currentIndex++] = person;
	}
	}

public class MainProgram {
	public static void Main(){
		var database = new Database();
		Console.WriteLine("Choose 0 to stop, 1 for  student, 2 for staff, 3 for printing all people, else for any kind of people");
		int x = Convert.ToInt32(Console.ReadLine());
		string name; int age;
		while(true){
			switch(x){
				case 1: Console.Write("Name: ");
				name = Console.ReadLine();
				Console.Write("Age: ");
				age = Convert.ToInt32(Console.ReadLine());
				Console.Write("Year: ");
				var year = Convert.ToInt32(Console.ReadLine());
				Console.Write("GPA: ");
				var gpa = Convert.ToInt32(Console.ReadLine());
				var student = new Student(name, age, year, gpa);
				database.AddStudent(student);
				break;
				case 2: Console.Write("Name: ");
				name = Console.ReadLine();
				Console.Write("Age: ");
				age = Convert.ToInt32(Console.ReadLine());
				Console.Write("Salary: ");
				var salary = Convert.ToInt32(Console.ReadLine());
				Console.Write("Join Year: ");
				var jyear = Convert.ToInt32(Console.ReadLine());
				var staff = new Staff(name, age, salary, jyear);
				database.AddStaff(staff);
				break;
				case 3: database.PrintAll();
				break;
				case 0: return;
				default: Console.Write("Name: ");
				name = Console.ReadLine();
				Console.Write("Age: ");
				age = Convert.ToInt32(Console.ReadLine());
				var person = new Person(name, age);
				database.AddPerson(person);
				break;
			} 
		Console.WriteLine("Choose 0 to stop, 1 for  student, 2 for staff, 3 for printing all people");
		 x = Convert.ToInt32(Console.ReadLine());
		}
	}
}
