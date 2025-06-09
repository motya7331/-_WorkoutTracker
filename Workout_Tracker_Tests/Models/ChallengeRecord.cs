namespace Workout_Tracker_Tests.Models
{
    public class ChallengeRecord
    {
        public int Id { get; set; }
        public int TraineeId { get; set; }
        public int ExerciseId { get; set; }
        public int Repetitions { get; set; }
        public DateTime Date { get; set; }
    }
}