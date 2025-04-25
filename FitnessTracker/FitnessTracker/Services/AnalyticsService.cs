using System.Collections.Generic;
using System.Linq;
using FitnessTracker.Models;

namespace FitnessTracker.Services
{
    public static class AnalyticsService
    {
        private static readonly List<ActivityLog> _logs = new List<ActivityLog>();

        public static void AddLog(ActivityLog log)
        {
            _logs.Add(log);
        }

        public static List<ActivityLog> GetLogs()
        {
            return _logs;
        }

        public static double TotalCaloriesBurned =>
            _logs.Sum(log => log.CaloriesBurned);

        public static Dictionary<string, double> CaloriesByActivity =>
            _logs
                .GroupBy(log => log.ActivityType)
                .ToDictionary(g => g.Key, g => g.Sum(l => l.CaloriesBurned));
    }
}
