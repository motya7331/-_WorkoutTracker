using Microsoft.EntityFrameworkCore;

namespace WorkoutTracker.Models
{
    public class WorkoutContext : DbContext
    {
        public DbSet<Trainee> Trainees { get; set; } = null!;
        public DbSet<Coach> Coaches { get; set; } = null!;
        public DbSet<Instructor> Instructors { get; set; } = null!;
        public DbSet<Group> Groups { get; set; } = null!;
        public DbSet<Exercise> Exercises { get; set; } = null!;
        public DbSet<WorkoutSchedule> WorkoutSchedules { get; set; } = null!;
        public DbSet<ChallengeSchedule> ChallengeSchedules { get; set; } = null!;
        public DbSet<DailyRecord> DailyRecords { get; set; } = null!;
        public DbSet<ChallengeRecord> ChallengeRecords { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\mxtyajezz\\source\\repos\\Workout_Tracker-master\\WorkoutTracker\\workouts.db");
        }

        public void EnsureDatabaseCreated()
        {
            Database.EnsureCreated();
        }
    }
}