
namespace LSP
{
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string? Title { get; set; }

        public abstract void Subscribe(Student std);
        public abstract string GetCourseDetails();
    }

    public class OnlineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            Console.WriteLine($"Student{std.Name} subscribed to the online course{Title}");
        }

        public override string GetCourseDetails()
        {
            return $"Online course: {Title}";
        }
    }

    public class OfflineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            Console.WriteLine($"Student {std.Name} subscribed to the offline course {Title}.");
        }

        public override string GetCourseDetails()
        {
            return $"Offline Course: {Title}";
        }
    }

    public class HybridCourse : Course
    {
        public override void Subscribe(Student std)
        {
            Console.WriteLine($"Student {std.Name} subscribed to the hybrid course {Title}.");
        }

        public override string GetCourseDetails()
        {
            return $"Hybrid Course;{Title}";
        }
    }

    class Program
    {
        static void Main()
        {
            Student student = new Student { Name = "Nicole"};

            List<Course> courses = new List<Course>
            {
                new OnlineCourse { CourseId = 1, Title = "C#"},
                new OfflineCourse { CourseId = 2, Title = "Data" },
                new HybridCourse { CourseId = 3, Title = "Database" }
            };

            foreach (var course in courses) 
            {
                course.Subscribe(student);
                Console.WriteLine(course.GetCourseDetails());
            }
        }
    }
   
}
