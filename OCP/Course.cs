
using OCP;

namespace OCP
{
    public class OnlineCourseSubscription : ISubscriptionStrategy
    {
        public void Subscribe(Student std)
        {
        //Codigo para suscribir a un curso en linea
        }
    }
    public class OfflineCourseSubscription : ISubscriptionStrategy
    {
        public void Subscribe(Student std)
        {
            //write code to subscribe to an online course
        }
    }

    public class HybridCourseSubscription : ISubscriptionStrategy
    {
        public void Subscribe(Student std)
        {
            //write code to subscribe to a offline course
        }
    }
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string? Title { get; set; }

        private ISubscriptionStrategy _subscriptionStrategy;

        public Course(ISubscriptionStrategy subscriptionStrategy)
        {
           _subscriptionStrategy = subscriptionStrategy;
        }

        public void Subscribe(Student std)
        { 
            _subscriptionStrategy.Subscribe(std);
        }
    }

    public class OnlineCourse : Course
    {
        public OnlineCourse() : base(new OnlineCourseSubscription()) { }
    }

    public class OfflineCourse : Course
    {
        public OfflineCourse() : base(new OfflineCourseSubscription()) { }
    }

    public class HybridCourse : Course
    {
        public HybridCourse() : base(new HybridCourseSubscription()) { }
    }

    public class Program
    {
        public static void Main()
        {
            Student student = new Student();

            Course HybridCourse = new HybridCourse();
            HybridCourse.Subscribe(student); 

            Course onlineCourse = new OnlineCourse();
            onlineCourse.Subscribe(student);

            Course offlineCourse = new OfflineCourse();
            offlineCourse.Subscribe(student);
        }
    }
}
