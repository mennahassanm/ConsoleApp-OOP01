using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_OOP01
{
    internal class Car
    {
        // Id 

        #region Attributes

        private int id; // 4
        private int speed; // 4 
        private string modle; // 8 

        #endregion

        #region Properties

        public string Modle
        {
            get { return modle; }
            set { modle = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        #endregion

        //public  string Address { get; set; } // Prop

        // CLR Will Generate Paramerterless Constructor
        // This Constructor Do Nothing


        // CTOR 

        //public Car()
        //{
        //} // Do Nothing


        //public Car ()
        //{
        //    Id = default;
        //    Modle = default;
        //    Speed = default;
        //}

        #region Class - Internal Constructor 

        public Car(int id, int speed, string modle) : this(id, speed)
        {
            //Id = id;
            //Speed = speed;
            Modle = modle;
        }

        public Car(int id, int speed) : this(id)
        {
            //Id = id;
            Speed = speed;
        }

        public Car(int id)
        {
            Id = id;
        }

        public override string ToString()
        {
            return $" Id : {Id} :: Speed : {Speed} :: Model : {Modle} ";
        }

        #endregion

    }
}
