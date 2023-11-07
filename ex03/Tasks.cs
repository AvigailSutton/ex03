using System.Reflection.Metadata;

namespace ex02
{
    
        public enum Preference
        {
           A ,B, C, D
        };

    public class Tasks
    {
        public int Id { get; } = 0;
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Time { get; set; }

        public Preference MyPreference { get; set; }

        public Tasks( string title, string description, DateTime time, Preference preference)
        {
            Id ++;
            Title = title;
            Description = description;
            Time = time;
            MyPreference = preference;

        }

    }
}
