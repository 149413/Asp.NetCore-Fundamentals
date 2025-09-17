namespace Demo_01
{
    internal class Car
    {
        #region Attributes
        private int id;  // 4
        private string model; // 4
        private long speed; // 8
        #endregion

        #region Properties [propfull + Tab]
        public long Speed
        {
            get { return speed; }
            set { speed = value; }
        }


        public string Model
        {
            get { return model; }
            set { model = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        #endregion


        #region Defualt Constructor
        // CLR: Generate ParameterLess Constructor
        // , Ths Constructo Do NoThing


        //public Car()  //[ Ctr + Tab]
        //{

        //} // Do NoThing

        //public Car()
        //{
        //    id = default;
        //    Model = default;
        //    Speed = default;
        //} 
        #endregion




        #region Chenning Constructor
        // Parametarize Constructor
        public Car(int id, string model, long speed) : this(id, model)
        {
            //Id = id;
            //Model = model;
            Speed = speed;
        }
        public Car(int id, string model) : this(id)
        {
            //Id = id;
            Model = model;
        }
        public Car(int id)
        {
            Id = id;
        }
        #endregion

        public override string ToString()
        {
            return $"Id: {Id} :: Name: {model} :: Speed {speed}";
        }





    }

}
