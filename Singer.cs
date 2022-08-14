using System;
using System.Collections.Generic;
using System.Text;

namespace homework345
{
    class Singer
    {
        string _name { get; set; }
        string _surname { get; set; }
        int _age { get; set; }
        

        public string name
        {
            get
            {
                return _name;

            }
            set
            {
                if (value.Length >= 100)
                {
                    value = _name;
                }
                if (value.Length >= 100)
                {
                    value = _surname;

                }
                if (value.Length >= 170)
                {
                    _ = _age;

                }
                

            }
        }
    }
}


        

    
