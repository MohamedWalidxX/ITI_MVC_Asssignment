namespace ITI_MVC_Asssignment.Models;

public class Instructor {
    public int Id { get; set; }
    public String Name { get; set; }
    public double Salary { get; set; }
    public String Address { get; set; }
    public String Image { get; set; }
    public int DepartmentId { get; set; }
    public Department DepartmentNavigation { get; set; }
    
    public int CourseId { get; set; }
    public Course CourseNavigation { get; set; }

}

