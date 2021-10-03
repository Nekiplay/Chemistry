using System.Collections.Generic;
using System.Linq;

namespace Chemistry.NETFramework.Library
{
    public class Element
    {
        public string Type { get; }
        public string Name { get; }
        public string ShortName { get; }
        public string ElectronicFormula { get; }
        public int SerialNumber { get; }
        public int Period { get; }
        public int Group { get; }
        public float Density { get; }
        public double MeltingPoint { get; }
        public double Mass { get; }
        public bool MainGroup { get; }
        public bool Metal { get; }
        public bool Oxidizer
        {
            get
            {
                Arbital last = Arbitali.Last();
                if (last.Electron > 6)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public List<Arbital> Arbitali { get; }

        public Element(string name, string shortname, string electronicformula, int serialnumber, int period, int group, float density, double meltingpoint, double mass, bool maingroup, bool metal, List<Arbital> arbitali)
        {
            this.Name = name;
            this.ShortName = shortname;
            this.ElectronicFormula = electronicformula;
            this.SerialNumber = serialnumber;
            this.Period = period;
            this.Group = group;
            this.Density = density;
            this.MeltingPoint = meltingpoint;
            this.MainGroup = maingroup;
            this.Metal = metal;
            this.Arbitali = arbitali;
            this.Mass = mass;
        }
        public Element(string name, string shortname, string electronicformula, int serialnumber, int period, int group, float density, double meltingpoint, double mass, bool maingroup, bool metal, List<Arbital> arbitali, string type)
        {
            this.Name = name;
            this.ShortName = shortname;
            this.ElectronicFormula = electronicformula;
            this.SerialNumber = serialnumber;
            this.Period = period;
            this.Group = group;
            this.Density = density;
            this.MeltingPoint = meltingpoint;
            this.MainGroup = maingroup;
            this.Metal = metal;
            this.Arbitali = arbitali;
            this.Mass = mass;
            this.Type = type;
        }

        public class Arbital
        {
            public int Electron { get; }
            public Arbital(int electron)
            {
                this.Electron = electron;
            }
        }
    }
}
