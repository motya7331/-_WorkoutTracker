namespace Workout_Tracker_Tests.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int GroupId { get; set; }
        public Group Group { get; set; } = null!;
    }
}