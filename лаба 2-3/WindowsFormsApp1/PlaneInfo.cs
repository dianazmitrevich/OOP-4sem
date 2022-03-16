using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WindowsFormsApp1
{
    [Serializable]

    public class PlaneInfo
    {
        public string PlaneModel, PlaneCapacity, PlaneLoadCapacity, PlaneYear;
        private string planeID , planeType;
        public Crew[] planeCrew = new Crew[] { };
        public DateTimeOffset PlaneTO;

        public string PlaneID
        {
            get => this.planeID;
            set
            {
                if (value.ToString().Length == 4)
                    this.planeID = value;
                else throw new ArgumentException("ID самолета должно состоять из 4 знаков!");
            }
        }

        public string PlaneType
        {
            get => this.planeType;
            set
            {
                string[] planeTypes = { "Пассажирский", "Грузовой", "Военный" };
                if (planeTypes.Contains(value)) this.planeType = value;
                else throw new ArgumentException("Выберите тип самолета из списка!");
            }
        }

        public Manufacturer planeManufacturer { get; set; }

        public PlaneInfo() { }

        public PlaneInfo(string planeID, string planeType, string planeModel, string planeCapacity, string planeLoadCapacity, string planeYear, DateTimeOffset planeTO)
        {
            this.PlaneID = planeID;
            this.PlaneType = planeType;
            this.PlaneModel = planeModel;
            this.PlaneCapacity = planeCapacity;
            this.PlaneLoadCapacity = planeLoadCapacity;
            this.PlaneYear = planeYear;
            this.PlaneTO = planeTO;
        }

        public override string ToString()
        {
            return $"{this.PlaneType} {this.PlaneModel} #{this.PlaneID}, " +
                $"вместимость - {this.PlaneCapacity} человек, грузоподъемность - {this.PlaneLoadCapacity}, " +
                $"год выпуска и дата последнего ТО - {this.PlaneYear} и {this.PlaneTO}." + Environment.NewLine;
        }
    }
}
