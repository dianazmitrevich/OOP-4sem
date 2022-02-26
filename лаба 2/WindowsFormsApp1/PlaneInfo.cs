using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class PlaneInfo
    {
        public int PlaneID;
        public string PlaneType;
        public string PlaneModel;
        public int PlaneCapacity;
        public int PlaneLoadCapacity;
        public int PlaneYear;
        public DateTimeOffset PlaneTO;
        public Manufacturer planeManufacturer;

        public PlaneInfo() { }

        public PlaneInfo(int planeID, string planeType, string planeModel, int planeCapacity, int planeLoadCapacity, int planeYear, DateTimeOffset planeTO)
        {
            this.PlaneID = planeID;
            this.PlaneType = planeType;
            this.PlaneModel = planeModel;
            this.PlaneCapacity = planeCapacity;
            this.PlaneLoadCapacity = planeLoadCapacity;
            this.PlaneYear = planeYear;
            this.PlaneTO = planeTO;
        }
    }
}
