namespace StandaloneSDKDemo.Models
{
    public class PlannedTime
    {
        public string In { get; set; }
        public string Out { get; set; }
        public string WorkTime { get; set; }
    }
    public class Break
    {
        public string Out { get; set; }
        public string In { get; set; }
    }
    public class InAndOut
    {
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
    }
    public class AttendanceReport
    {
        public string EmployeeName { get; set; }
        public PlannedTime PlannedTime { get; set; }
        public InAndOut InAndOut { get; set; }
        public Break Break { get; set; }
        public string Actual { get; set; }
        public string OverTime { get; set; }
        public string LateIn { get; set; }
        public string EarlyOut { get; set; }
        public string EarlyIn { get; set; }
        public string LateOut { get; set; }
        public string Remark { get; set; }
    }
}
