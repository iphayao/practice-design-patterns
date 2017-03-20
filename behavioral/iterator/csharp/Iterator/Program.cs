using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    class RadioStation
    {
        protected double frequency;
        public RadioStation(double frequency)
        {
            this.frequency = frequency;
        }
        public double GetFrequency()
        {
            return this.frequency;
        }
    }
    class StationList : IEnumerable<RadioStation>
    {
        protected List<RadioStation> stations = new List<RadioStation>();
        protected int counter = 0;

        public void AddStation(RadioStation station)
        {
            this.stations.Add(station);
        }
        public bool RemoveStation(RadioStation station)
        {
            double toRemoveFrequency = station.GetFrequency();
            return this.stations.Remove(station);
        }

        public IEnumerator<RadioStation> GetEnumerator()
        {
            return stations.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StationList stationList = new StationList();

            stationList.AddStation(new RadioStation(89));
            stationList.AddStation(new RadioStation(101));
            stationList.AddStation(new RadioStation(102));
            stationList.AddStation(new RadioStation(103.2));
            
            foreach (var station in stationList)
            {
                Console.WriteLine(station.GetFrequency());
                
            }
        }
    }
}
