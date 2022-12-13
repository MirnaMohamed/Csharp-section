using System;
namespace Program;

public abstract class Person {
	string name;
	int age ;
	public Person (string n, int a){
		name = n;
		age = a;
	}
	public abstract void Print();
} 

public class MainProgram {
	public static void Main(){
		
	}
}
