namespace WorkoutTracker.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Instructor> Instructors { get; set; } = new List<Instructor>();
        public List<Trainee> Trainees { get; set; } = new List<Trainee>();
    }
}