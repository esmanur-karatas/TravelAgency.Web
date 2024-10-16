namespace SignalRApi.DAL
{
    public enum ECity
    {
        Antalya = 1,
        Ankara = 2,
        Adana = 3,
        Adıyaman = 4,
        Elazığ = 5,
    }
    public class Visitor
    {
        public int VisitorId { get; set; }
        public ECity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
