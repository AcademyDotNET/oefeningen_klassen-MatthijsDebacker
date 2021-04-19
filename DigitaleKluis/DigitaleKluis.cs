using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitaleKluis
{
    class DigitaleKluis
    {
        public DigitaleKluis(int code)
        {
            _code = code;
        }

        private int _aantalPogingen = 0;
        private int _code;
        private bool _canShowCode = true;

        public bool CanShowCode
        {
            get { return _canShowCode; }
            set { _canShowCode = value; }
        }

        public int Code 
        { 
            get 
            {
                if (CanShowCode)
                {
                    return _code;
                }
                else
                {
                    return -666;
                }
            } 
            private set 
            { 
                _code = value; 
            } 
        }

        public int CodeLevel 
        {
            get
            {
                return _code / 1000;
            }
        }

        public bool TryCode(int code)
        {
            if(code == -666)
            {
                Console.WriteLine("Cheater.");
                return false;
            }
            else if(code == _code)
            {
                Console.WriteLine("Deze code is geldig.");
                return true;
            }
            else if(code != _code)
            {
                _aantalPogingen++;
                Console.WriteLine($"Deze code is niet geldig. (Aantal pogingen: {_aantalPogingen})");
                return false;
            }
            return false;
        }
    }
}
