using System;
public class Student
{
    public string name{ get; set; }
    public List<int> grades {  get; set; }
    public Student()
	{
        name = "Unknown";
        grades = new List<int>(5);
	}
}
