using System.Xml.Serialization;

namespace WinFormsApp1
{
    [XmlType("Employee")]
    // Клас працівника
    public class Person
    {
        public string? Name { get; init; }
        public DateTime Time { get; set; }

        public Person() { }
        public Person(string? Name, DateTime Time)
        {
            this.Name = Name;
            this.Time = Time;
        }

        public bool IsLate()
        {
            return (this.Time < new DateTime(this.Time.Year, this.Time.Month, this.Time.Day, 8, 0, 0));
        }
    }
}