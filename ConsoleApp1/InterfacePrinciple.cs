using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class InterfacePrinciple { }
    public abstract class Type { public string Selection { get; set; } }

    public interface IBuilding
    {
        public bool ILandCanBeBought();
        public bool IMultiStorey();
    }
    public interface IHouse
    {
        public bool ILandCanBeBought();
        public bool ISingleStorey();
    }

    
    public class ShanghaiTower : Type, IBuilding
    {
        public bool ILandCanBeBought() { throw new NotImplementedException(); }
        public bool IMultiStorey() { throw new NotImplementedException(); }
    }
    public class PrefabricateHouses : Type, IHouse
    {
        public bool ILandCanBeBought() { throw new NotImplementedException(); }

        public bool ISingleStorey() { throw new NotImplementedException(); }
    }

}
