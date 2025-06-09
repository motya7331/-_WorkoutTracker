namespace Workout_Tracker_Tests.Models
{
    public class ChallengeSchedule
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int ExerciseId { get; set; }
        public DateTime Date { get; set; }
    }
}