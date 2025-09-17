namespace Task02_ProtectedAccessModifiers.Task02_Protected_Modifiers
{
    // Access Modifiers

    //1. Protected   ==> Accees By Only
    // 1. The Same Class
    // 2. Any Derived Class [Inside or Outside The Project] 

    //2. Private Protecred ==> Accessed By
    // 1. The Same Class
    // 2. Only Derived Class [Inside The Same Project]

    //3. Internal Protected ==> Accessed By
    //1. Any Class Inside The Same Project ----> [Same  - Derived - Un_Derived Class]
    //2. Any Derived Class Outside The Project



    public class BaseClass
    {

        protected int Protected { get; set; }
        private protected int PrivateProtected { get; set; }
        internal protected int InternalProtected { get; set; }

        public BaseClass()
        {
            Protected = 10;
            PrivateProtected = 20;
            InternalProtected = 30;
        }
    }
}

