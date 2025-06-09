namespace WorkoutTracker.Models
{
    public class ChallengeSchedule
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public Group? Group { get; set; }
        public int ExerciseId { get; set; }
        public Exercise? Exercise { get; set; }
        public DateTime Date { get; set; }
        public string? ChallengeType { get; set; }
    }
}