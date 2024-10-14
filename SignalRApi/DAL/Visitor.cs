namespace SignalRApi.DAL
{
    public enum ECity
    {
        Antalya = 1,
        Ankara = 2,
        Adana = 3,
        Adıyaman = 4,
        Elazığ = 5,
        Malatya = 6,
        Muş = 7,
        Bursa = 8,
        Manisa = 9,
        Mersin = 10,
        Bingöl = 11,
        Nevşehir = 12,
        Niğde = 13,
        Van = 14, 
        Diyarbakır = 15, 
        İstanbul = 16
    }
    public class Visitor
    {
        public int VisitorId { get; set; }
        public ECity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
