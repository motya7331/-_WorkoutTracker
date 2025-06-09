namespace Workout_Tracker_Tests.Models
{
    public class WorkoutSchedule
    {
        public int Id { get; set; }
        public int TraineeId { get; set; }
        public int ExerciseId { get; set; }
        public DateTime Date { get; set; }
    }
}