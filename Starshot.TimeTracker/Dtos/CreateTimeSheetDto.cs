namespace Starshot.TimeTracker.Dtos
{
    public class CreateTimeSheetDto
    {
        public int EmployeeId { get; set; }
        public DateTime ClocIn { get; set; }
        public DateTime ClockOut { get; set; }
    }
}
