namespace StandaloneSDKDemo.Models
{
    public class AttendanceLog
    {
        public string user_id { get; set; }
        public bool is_enabled { get; set; }
        public string name { get; set; }
        public int privilege { get; set; }
        public string card_number { get; set; }
        public string verify_date { get; set; }
        public int verify_type { get; set; }
        public int verify_state { get; set; }
        public int work_code { get; set; }
    }
}
