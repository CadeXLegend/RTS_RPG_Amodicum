using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RTSUnits
{ 
    /// <summary>
  /// The Base Template Class for All Units.
  /// </summary>
    abstract class Unit
    {
        #region Variables
        private int HP { get; set; }
        private string ID { get; set; }
        public enum UnitType
        {
            Infantry, Hero, Mercenary, Neutral, Summoned, Worker
        }
        private int GoldCost { get; set; }
        private int WoodCost { get; set; }
        private int StoneCost { get; set; }

        private float ProductionTime { get; set; }
        #endregion

        #region Methods/Functions
        /// <summary>
        /// Set the Unit's Cost to be Produced.
        /// </summary>
        public virtual void SetUnitCosts(int GoldCost, int WoodCost, int StoneCost)
        {
            this.GoldCost = GoldCost;
            this.WoodCost = WoodCost;
            this.StoneCost = StoneCost;
        }

        #region Get/Set Values
        #region HP
        public virtual int GetHP()
        {
            if (HP < 0)
                HP = 0;
            return HP;
        }
        public virtual void SetHP(int value)
        {
            HP = value;
        }
        #endregion

        #region ID
        public virtual string GetID()
        {
            if (ID == string.Empty)
                return "There is no ID Assigned to this Unit";
            return ID;
        }
        public virtual void SetID(string value)
        {
            ID = value;
        }
        #endregion

        #region  ProductionTime
        /// <summary>
        /// Returns the Unit's Production Time
        /// </summary>
        /// <returns></returns>
        public virtual float GetProductionTime()
        {
            if (ProductionTime < 0)
                ProductionTime = 0;
            return ProductionTime;
        }
        /// <summary>
        /// Sets the Unit's Production Time
        /// </summary>
        public virtual void SetProductionTime(float value)
        {
            ProductionTime = value;
        }
        public virtual void SetProductionTime(int value)
        {
            ProductionTime = value;
        }
        public virtual void SetProductionTime(double value)
        {
            ProductionTime = (float)value;
        }
        #endregion
        #endregion

        /// <summary>
        /// Returns the Unit's Cost as a String.
        /// </summary>
        public virtual string GetUnitCosts()
        {
            string temp =
                "Gold Cost: " + GoldCost +
                "\nWood Cost: " + WoodCost +
                "\nStone Cost: " + StoneCost;
            return temp;
        }

        /// <summary>
        /// Return a String of Basic Information from the Standard Unit.
        /// </summary>
        /// <returns></returns>
        public virtual string GetUnitInformation()
        {
            string temp =
                "HP: " + GetHP() +
                "\nID: " + GetID() +
                "\nTime To Build: " + GetProductionTime();
            return temp;
        }
        #endregion
    }

    class Hero : Unit
    {
        #region Variables
        private UnitType TypeOfUnit { get; set; }
        public enum HeroType
        {
            Melee, Caster, Tank, Enhancer, Summoner
        }
        private HeroType TypeOfHero { get; set; }
        private string Name { get; set; }
        private int Armor { get; set; }
        private int Mana { get; set; }

        private float AttackSpeed { get; set; }
        private float CastSpeed { get; set; }

        private int HealthRegen { get; set; }
        private int ManaRegen { get; set; }
        #endregion

        #region Constructor
        public Hero(string Name, int HP, int Armor, int Mana, float AttackSpeed, float CastSpeed, int HealthRegen, int ManaRegen, string ID, HeroType HeroType, float ProductionTime)
        {
            SetName(Name);
            SetHP(HP);
            SetArmor(Armor);
            SetMana(Mana);
            SetAttackSpeed(AttackSpeed);
            SetCastSpeed(CastSpeed);
            SetHealthRegen(HealthRegen);
            SetManaRegen(ManaRegen);
            SetID(ID);
            SetUnitType(UnitType.Hero);
            SetHeroType(HeroType);
            SetProductionTime(ProductionTime);
        }
        #endregion

        #region Methods
        #region Get/Set Values
        #region Name
        /// <summary>
        /// Returns the Hero's Name
        /// </summary>
        /// <returns></returns>
        public virtual string GetName()
        {
            if (Name == string.Empty)
                return "No Name has been Given to this Hero.";
            return Name;
        }
        /// <summary>
        /// Sets the Hero's Name
        /// </summary>
        public virtual void SetName(string value)
        {
            Name = value;
        }
        #endregion

        #region Armor
        /// <summary>
        /// Returns the Hero's Armor
        /// </summary>
        /// <returns></returns>
        public virtual int GetArmor()
        {
            if (Armor < 0)
                Armor = 0;
            return Armor;
        }
        /// <summary>
        /// Sets the Hero's Armor
        /// </summary>
        public virtual void SetArmor(int value)
        {
            Armor = value;
        }
        #endregion

        #region Mana
        /// <summary>
        /// Returns the Unit's Mana
        /// </summary>
        /// <returns></returns>
        public virtual int GetMana()
        {
            if (Mana < 0)
                Mana = 0;
            return Mana;
        }
        /// <summary>
        /// Sets the Hero's Mana
        /// </summary>
        public virtual void SetMana(int value)
        {
            Mana = value;
        }
        #endregion

        #region Attack Speed
        /// <summary>
        /// Returns the Hero's Attack Speed
        /// </summary>
        /// <returns></returns>
        public virtual float GetAttackSpeed()
        {
            if (AttackSpeed < 0)
                AttackSpeed = 0;
            return AttackSpeed;
        }
        /// <summary>
        /// Sets the Hero's Attack Speed
        /// </summary>
        public virtual void SetAttackSpeed(int value)
        {
            AttackSpeed = value;
        }
        public virtual void SetAttackSpeed(float value)
        {
            AttackSpeed = value;
        }
        public virtual void SetAttackSpeed(double value)
        {
            AttackSpeed = (float)value;
        }
        #endregion

        #region Cast Speed
        /// <summary>
        /// Returns the Hero's Cast Speed
        /// </summary>
        /// <returns></returns>
        public virtual float GetCastSpeed()
        {
            if (CastSpeed < 0)
                CastSpeed = 0;
            return CastSpeed;
        }
        /// <summary>
        /// Sets the Hero's Cast Speed
        /// </summary>
        public virtual void SetCastSpeed(int value)
        {
            CastSpeed = value;
        }
        public virtual void SetCastSpeed(float value)
        {
            CastSpeed = value;
        }
        public virtual void SetCastSpeed(double value)
        {
            CastSpeed = (float)value;
        }
        #endregion

        #region Health Regen
        /// <summary>
        /// Returns the Hero's Health Regen
        /// </summary>
        /// <returns></returns>
        public virtual int GetHealthRegen()
        {
            if (HealthRegen < 0)
                HealthRegen = 0;
            return HealthRegen;
        }
        /// <summary>
        /// Sets the Hero's Health Regen
        /// </summary>
        public virtual void SetHealthRegen(int value)
        {
            HealthRegen = value;
        }
        #endregion

        #region Mana Regen
        /// <summary>
        /// Returns the Hero's Mana Regen
        /// </summary>
        /// <returns></returns>
        public virtual int GetManaRegen()
        {
            if (ManaRegen < 0)
                ManaRegen = 0;
            return ManaRegen;
        }
        /// <summary>
        /// Sets the Hero's Mana Regen
        /// </summary>
        public virtual void SetManaRegen(int value)
        {
            ManaRegen = value;
        }
        #endregion

        #region Unit Type
        /// <summary>
        /// Sets the Hero's Type.
        /// </summary>
        public virtual void SetUnitType(UnitType UnitType)
        {
            TypeOfUnit = UnitType;
        }

        /// <summary>
        /// Returns the Hero's Type as a String.
        /// </summary>
        public string GetUnitType()
        {
            string temp = TypeOfUnit.ToString();
            return temp;
        }
        #endregion

        #region Hero Type
        /// <summary>
        /// Sets the Hero's Type.
        /// </summary>
        public virtual void SetHeroType(HeroType HeroType)
        {
            TypeOfHero = HeroType;
        }

        /// <summary>
        /// Returns the Hero's Type as a String.
        /// </summary>
        public string GetHeroType()
        {
            string temp = TypeOfHero.ToString();
            return temp;
        }
        #endregion
        #endregion

        /// <summary>
        /// Extends the Return String from Building - GetHouseInformation() for Heroes.
        /// </summary>
        /// <returns></returns>
        public override string GetUnitInformation()
        {
            string temp =
               "Name: " + GetName() +
               "\nID: " + GetID() +
               "\nUnit Type: " + GetUnitType() +
               "\nHero Type: " + GetHeroType() +
               "\nHP: " + GetHP() +
               "\nArmor: " + GetArmor() +
               "\nMana: " + GetMana() +
               "\nAttack Speed: " + GetAttackSpeed() +
               "\nCast Speed: " + GetCastSpeed() +
               "\nHealth Regen: " + GetHealthRegen() +
               "\nMana Regen: " + GetManaRegen() +
               "\nTime To Build: " + GetProductionTime();
            return temp;
        }
        #endregion
    }
}
