namespace WorkoutTracker.Models
{
    public class Coach
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int TraineeId { get; set; }
        public Trainee? Trainee { get; set; }
    }
}