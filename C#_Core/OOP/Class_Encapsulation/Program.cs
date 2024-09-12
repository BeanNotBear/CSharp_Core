using DemoPresent;

class Program
{
    public static void Main1(string[] args)
    {

        Student student = new Student();

        // calls set accessor of the property Name
        student.Name = "Nguyen Van A";
        // calls set accessor of the property Name
        student.Age = 21;

        // Displaying values of the variables
        Console.WriteLine("Name : " + student.Name);
        Console.WriteLine("Age : " + student.Age);

        // calls set accessor of the property Name
        student.Name = "Tran Van B";
        // calls set accessor of the property Name
        student.Age = 19;

        // Display
        student.Infor();
    }
}