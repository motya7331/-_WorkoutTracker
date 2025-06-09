namespace WorkoutTracker.Models
{
    public class ChallengeRecord
    {
        public int Id { get; set; }
        public int TraineeId { get; set; }
        public Trainee? Trainee { get; set; }
        public int ChallengeScheduleId { get; set; }
        public ChallengeSchedule? ChallengeSchedule { get; set; }
        public int Reps { get; set; }
        public DateTime Date { get; set; }
    }
}