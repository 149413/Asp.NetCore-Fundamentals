namespace Common
{
    // Access Modifeirs : C# KeyWords Indicate To Accessability Scope:
    // 1. Private
    // 2. Private Protected
    // 3. Protected
    // 4. Internal
    // 5. Internal Protected
    // 6. Public

    //What Cam Write Inside The NameSpace ?

    // 1. Class
    // 2. Struct
    // 3. Interfce
    // 4. Enum

    // What Access Modifiers Inside NameSpace ?
    // 1. Internal: Access in The Same Project
    // 2. Public  : Acess Everyware

    //Defualt Access Modifer Inside NameSpace is "Internal"


    //what is Write Inside The Class or struct ?

    //1. Attributes [Fiels - member Variables]
    //2. Properties [Full  Properties  -   Automitic Properties   -   Special Properties (Indexer) ]
    //3. Methods - Function
    //4. Event

    //Access Modifiers inSidde Class : 
    // 1. Private
    // 2. Private Protected
    // 3. Protected
    // 4. Internal
    // 5. Internal Protected
    // 6. Public


    //Access Modifiers inSidde struct :
    //1. Private  : Inside The Same Class Only
    //2. Internal : Inside the Same Project
    //3. Public   : Everywhare


    // Defualt Access Inside Class or struct is "Private"


    //What Can Write Inside InterFace ?

    // 1. Segnature Of Methods [Name - Return DataType - Parameters]
    // 2. Senature Of Property
    // 3. Defualt Implement Methods [C# 8.0  .Net Core 3.1] ---> Allow "Private" Accessability Inside InterFace

    // Access Modifeirs Inside InterFace:

    // All Modifiers Except "Private" Access

    // 1. Protected
    // 2. Internal
    // 3. Internal Protected
    // 4. Public


    // Defualt Access Inside Interface is "Public"
    // As Its Must Overide The Mothos of InterFace Inside The Interited Classes (Child)



    internal class TypeA
    {
        void Func01()
        {
            TypeB typeB = new TypeB(); // Valide : TypeB is Internal

            TypeA typeA = new TypeA(); // The Same Class

            //typeB.X = 1; // InValid : Prinate
            typeB.Y = 2; // Valid
            typeB.Z = 3; // Valid
        }



    }
}
