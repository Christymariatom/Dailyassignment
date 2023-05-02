using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Requirement_5

{

    public class InvalidEmailException : Exception

    {

        string email;

        public InvalidEmailException()

        {

        }

        public InvalidEmailException(string email)

        {

            this.email = email;

        }

        public void inform()

        {

            Console.WriteLine("invalid mailid");

        }

    }

}


/*
////////////////////////////////////////////////////////////////

abstract class Car

{

    private long _id;

    private string _name;

    public long Id

    {

        get

        {

            return _id;

        }

        set

        {

            _id = value;

        }

    }

    public string Name

    {

        get

        {

            return _name;

        }

        set

        {

            _name = value;

        }

    }

    public Car()

    {

    }

    public Car(long id, string name)

    {

        _id = Id;

        _name = Name;

    }

    public abstract double CalculateDriveCost(double km);

}

class HatchBack : Car

{

    private bool _powerWindowsEnabled;

    private bool _automaticGear;

    public bool PowerWindowsEnabled

    {

        get

        {

            return _powerWindowsEnabled;

        }

        set

        {

            _powerWindowsEnabled = value;

        }

    }

    public bool AutomaticGear

    {

        get

        {

            return _automaticGear;

        }

        set

        {

            _automaticGear = value;

        }

    }

    public HatchBack()

    {

    }

    public HatchBack(long id, string name, bool powerWindowsEnabled, bool automaticGear) : base(id, name)

    {

        _powerWindowsEnabled = powerWindowsEnabled;

        _automaticGear = automaticGear;

    }

    public override double CalculateDriveCost(double km);

    {

     double costPerKm =

    class Sedan : Car

    {

        private bool _absEnabled;

        private Int32 _bootspace;

        public bool AbsEnabled

        {

            get

            {

                return _absEnabled;

            }

            set

            {

                _absEnabled = value;

            }

        }

        public Int32 Bootspace

        {

            get

            {

                return _bootspace;

            }

            set

            {

                _bootspace = value;

            }

        }

        public Sedan()

        {

        }

        public Sedan(long id, string name, bool absEnabled, int bootspace) : base(id, name)

        {

            _absEnabled = absEnabled;

            _bootspace = bootspace;

        }

    }

    class UtilityCar : Car

    {

        private bool _rearCoolingVents;

        public bool RearCoolingVents

        {

            get

            {

                return _rearCoolingVents;

            }

            set

            {

                _rearCoolingVents = value;

            }

        }

        public UtilityCar()

        {

        }

        public UtilityCar(long id, string name, bool rearCoolingVents) : base(id, name)

        {

            _rearCoolingVents = rearCoolingVents;

        }

    }

}
*/