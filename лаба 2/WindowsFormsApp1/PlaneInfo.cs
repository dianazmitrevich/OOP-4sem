using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class PlaneInfo
    {
        public string PlaneID;
        public string PlaneType;
        public string PlaneModel;
        public string PlaneCapacity;
        public string PlaneLoadCapacity;
        public string PlaneYear;
        public DateTimeOffset PlaneTO;
        public Manufacturer planeManufacturer;

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
                $"год выпуска и дата последнего ТО - {this.PlaneYear} и {this.PlaneTO}.";
        }
    }
}
