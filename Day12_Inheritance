using System;
using System.Linq;

class Person{
    protected string firstName;
    protected string lastName;
    protected int id;
    
    public Person(){}
    public Person(string firstName, string lastName, int identification){
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
    }
    public void printPerson(){
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
    }
}

class Student : Person{
    private int[] testScores;
    public Student(string firstName, string lastName, int identification, int[] scores)
    {
        this.testScores = scores;
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public char Calculate()
    {
        char score = 'N';
        int tempSum = 0;
        int tempDevisor = testScores.Length;

        foreach (int i in testScores)
        {
            tempSum = tempSum + i;
        }
        
        int avg = tempSum / tempDevisor;

        if (avg < 40)
        {
            score = 'T';
        }
        else if (39 < avg && avg < 55)
        {
            score = 'D';            
        }
        else if (54 < avg && avg < 70)
        {
            score = 'P';            
        }
        else if (69 < avg && avg < 80)
        {
            score = 'A';            
        }
        else if (79 < avg && avg < 90)
        {
            score = 'E';            
        }
        else if (89 < avg && avg < 101)
        {
            score = 'O';            
        }
        return score;
    }
}

class Solution {
    static void Main() {
        string[] inputs = Console.ReadLine().Split();
        string firstName = inputs[0];
        string lastName = inputs[1];
        int id = Convert.ToInt32(inputs[2]);
        int numScores = Convert.ToInt32(Console.ReadLine());
        inputs = Console.ReadLine().Split();
        int[] scores = new int[numScores];
        for(int i = 0; i < numScores; i++){
            scores[i]= Convert.ToInt32(inputs[i]);
        } 
        
        Student s = new Student(firstName, lastName, id, scores);
        s.printPerson();
        Console.WriteLine("Grade: " + s.Calculate() + "\n");
    }
}
