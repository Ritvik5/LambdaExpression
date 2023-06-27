namespace LambdaExpression
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Lambda Expression!!!\n");

            List<Student> students = new List<Student>();
            StudentDataMangement.AddStudentData(students);
            //StudentDataMangement.DisplayStudentData(students);
            StudentDataMangement.RetrieveBetweenRange(students);
        }
    }
}