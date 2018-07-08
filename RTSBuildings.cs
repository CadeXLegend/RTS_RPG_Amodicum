using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSBuildings
{
    /// <summary>
    /// The Base Template Class for All Buildings.
    /// </summary>
    abstract class Building
    {
        #region Variables
        private int HP { get; set; }
        private string ID { get; set; }
        public enum BuildingType
        {
            Unit, Resource, Upgrade
        }
        private int GoldCost { get; set; }
        private int WoodCost { get; set; }
        private int StoneCost { get; set; }

        private float BuildTime { get; set; }
        #endregion

        #region Methods/Functions
        /// <summary>
        /// Set the Building's Cost to be Built.
        /// </summary>
        public virtual void SetBuildingCosts(int GoldCost, int WoodCost, int StoneCost)
        {
            this.GoldCost = GoldCost;
            this.WoodCost = WoodCost;
            this.StoneCost = StoneCost;
        }

        #region Get/Set Values
        #region HP
        /// <summary>
        /// Returns the Building's HP
        /// </summary>
        /// <returns></returns>
        public virtual int GetHP()
        {
            if (HP < 0)
                HP = 0;
            return HP;
        }
        /// <summary>
        /// Sets the Building's HP
        /// </summary>
        public virtual void SetHP(int value)
        {
            HP = value;
        }
        #endregion

        #region ID
        /// <summary>
        /// Returns the Building's ID
        /// </summary>
        /// <returns></returns>
        public virtual string GetID()
        {
            return ID;
        }
        /// <summary>
        /// Sets the Building's ID
        /// </summary>
        /// <returns></returns>
        public virtual void SetID(string value)
        {
            ID = value;
        }
        #endregion

        #region  BuildTime
        /// <summary>
        /// Returns the Building's Build Time
        /// </summary>
        /// <returns></returns>
        public virtual float GetBuildTime()
        {
            return BuildTime;
        }
        /// <summary>
        /// Sets the Building's Build Time
        /// </summary>
        public virtual void SetBuildTime(float value)
        {
            BuildTime = value;
        }
        public virtual void SetBuildTime(int value)
        {
            BuildTime = value;
        }
        public virtual void SetBuildTime(double value)
        {
            BuildTime = (float)value;
        }
        #endregion
        #endregion

        /// <summary>
        /// Returns the Building's Cost as a String.
        /// </summary>
        public virtual string GetBuildingCosts()
        {
            string temp =
                "Gold Cost: " + GoldCost +
                "\nWood Cost: " + WoodCost +
                "\nStone Cost: " + StoneCost;
            return temp;
        }

        /// <summary>
        /// Return a String of Basic Information from the Standard Building.
        /// </summary>
        /// <returns></returns>
        public virtual string GetHouseInformation()
        {
            string temp =
                "HP: " + GetHP() +
                "\nID: " + GetID() +
                "\nTime To Build: " + GetBuildTime();
            return temp;
        }
        #endregion
    }

    /// <summary>
    /// The House Class for the Resource Based Pedestrian Building.
    /// </summary>
    class House : Building
    {
        #region Variables
        private BuildingType TypeOfHouse { get; set; }
        private int Population { get; set; }
        #endregion

        #region  Constructor
        public House(int HP, string ID, BuildingType HouseType, float BuildTime)
        {
            SetHP(HP);
            SetID(ID);
            SetBuildTime(BuildTime);
            SetHouseType(HouseType);
            SetHousePopulation(2);
        }
        #endregion

        #region  Methods
        #region Get/Set Values

        #region Population
        /// <summary>
        /// Use to Set the House's Population.
        /// </summary>
        public virtual void SetHousePopulation(int value)
        {
            Population = value;
        }

        /// <summary>
        /// Returns the House's Population.
        /// </summary>
        public virtual int GetHousePopulation()
        {
            return Population;
        }
        #endregion

        #region House Type
        /// <summary>
        /// Sets the House's Type.
        /// </summary>
        public virtual void SetHouseType(BuildingType TypeOfHouse)
        {
            this.TypeOfHouse = TypeOfHouse;
        }

        /// <summary>
        /// Returns the House's Type as a String.
        /// </summary>
        public string GetHouseType()
        {
            string temp = TypeOfHouse.ToString();
            return temp;
        }
        #endregion
        #endregion

        /// <summary>
        /// Extends the Return String from Building - GetHouseInformation() for Houses.
        /// </summary>
        /// <returns></returns>
        public override string GetHouseInformation()
        {
            string temp = 
                "HP: " + GetHP() + 
                "\nID: " + GetID() + 
                "\nTime To Build: " + GetBuildTime() + 
                "\nType of House: " + GetHouseType() + 
                "\nPopulation Provided By House: " + GetHousePopulation();
            return temp;
        }
        #endregion
    }
}
