namespace WorkoutTracker.Models
{
    public class WorkoutSchedule
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public Group? Group { get; set; }
        public int InstructorId { get; set; }
        public Instructor? Instructor { get; set; }
        public int ExerciseId { get; set; }
        public Exercise? Exercise { get; set; }
        public DateTime Date { get; set; }
        public string? TimeSlot { get; set; }
    }
}