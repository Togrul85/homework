using System;
using System.Collections.Generic;
using System.Text;

namespace homework345
{
    class Song
    {
        public string _name { get; set; }
        public string _genre { get; set; }
        public string _singer { get; set; }
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
            }
        }


    }
}
