namespace Starshot.TimeTracker.Dtos
{
    public class ReadTimeSheetDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime ClocIn { get; set; }
        public DateTime ClockOut { get; set; }
    }
}
