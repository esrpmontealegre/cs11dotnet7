using Class.Shared;

namespace Class.Shared
{
    public class Person:object, IComparable<Person>
    {
        public string? Name { get; set; }
        public DateTime Birthday { get; set; }

        public void ConsoleWrite() 
        {
            WriteLine($"{Name} was born on: {Birthday:dddd}");
        }

        public int MethodIWannaCall(string input)
        {
            return input.Length;
        }

        //delegate field
        //public EventHandler? ShoutOut;
        public event EventHandler? ShoutOut;



        //data field
        public int angerLevel;

        //method
        public void Kalabet()
        {
            angerLevel++;
            if (angerLevel >= 3) 
            {
                //if something is listening
                if(ShoutOut != null) 
                { 
                    //then call the delegate
                    ShoutOut(this, EventArgs.Empty);
                    
                }
                //ShoutOut?.Invoke(this,EventArgs.Empty)
            }
        }

        public int CompareTo(Person? other)
        {
            int posn;

            if ((this is not null) && (other is not null))
            {
                if ((Name is not null) && (other.Name is not null))
                {
                    //if both name vals are not null, use string imp of compareTo
                    posn = Name.CompareTo(other.Name);
                }else if ((Name is not null) && (other.Name is null))
                {

                    posn = -1;
                }
                else if ((Name is null) && (other.Name is not null))
                {

                    posn = 1;
                }
                else
                {
                    posn = 0;
                }
            }
            else if ((this is not null) && (other is null))
            {
                posn = -1;
            }
            else if ((this is  null) && (other is not null))
            {
                posn = 1;
            }
            else 
            { 
                posn = 0; 
            }

            return posn;

        }
    }
    
}

