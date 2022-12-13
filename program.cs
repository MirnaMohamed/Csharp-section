using System;
namespace Program;

public abstract class Person {
	public string name;
	public int age ;
	public Person (string myname, int a){
		name = myname;
		age = a;
	}
	public abstract void Print();
} 
public class Student : Person{
	public int Year ;
	public float GPA ;
	public Student (string n, int a, int y, int g):base(name, age){
		name=n;
		age =a;
		Year = y;
		GPA =g;
	}
	public override void Print(){
		Console.WriteLine($"My name is {0} and my GPA is {1}", name, GPA);
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
	}

public class Staff: Person {
	public double Salary;
	public int JoinYear;
	public Staff (string myname, int a, double salary, int jyear){
		name = myname;
		age = a;
		Salary = salary;
		JoinYear = jyear;
	}
	public override void Print(){
		Console.WriteLine($"My name is {0}, my age is {1}, and my salary is {2}", name, age, Salary);
	}
}

public class MainProgram {
	public static void Main(){
		var database = new Database();
		Console.Write("Name: ");
		var name = Console.ReadLine();
		Console.Write("Age: ");
		var age = Convert.ToInt32(Console.ReadLine());
		Console.Write("Year: ");
		var year = Convert.ToInt32(Console.ReadLine());
		Console.Write("GPA: ");
		var gpa = Convert.ToInt32(Console.ReadLine());
		var student = new Student(name, age, year, gpa);
		database.AddStudent(student);
		Console.WriteLine("The student is added successfully");
	}
}
