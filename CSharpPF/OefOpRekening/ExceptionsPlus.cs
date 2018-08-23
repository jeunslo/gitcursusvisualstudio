using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefOpRekening
{
    public class DateTimeException : Exception
    {
        private DateTime ongeldigDateTimeValue;

        public DateTime OngeldigDateTime
        {
            get
            {
                return ongeldigDateTimeValue;
            }
            set
            {
                ongeldigDateTimeValue = value;
            }
        }

        public DateTimeException(string message, DateTime ongeldigDateTime) : base(message)
        {
            OngeldigDateTime = ongeldigDateTime;
        }
    }

    public class OngeldigRekeningnummerException : Exception
    {
        private string ongeldigRekeningnummerValue;

        public string OngeldigRekeningnummer
        {
            get
            {
                return ongeldigRekeningnummerValue;
            }
            set
            {
                ongeldigRekeningnummerValue = value;
            }
        }

        public OngeldigRekeningnummerException(string message, string ongeldigRekeningnummer) : base(message)
        {
            OngeldigRekeningnummer = ongeldigRekeningnummer;
        }
    }

    public class OngeldigPositieveWaardeException : Exception
    {
        private decimal ongeldigPositieveWaardeValue;

        public decimal OngeldigPositieveWaarde
        {
            get
            {
                return ongeldigPositieveWaardeValue;
            }
            set
            {
                ongeldigPositieveWaardeValue = value;
            }
        }

        public OngeldigPositieveWaardeException(string message, decimal ongeldigPositieveWaarde) : base(message)
        {
            OngeldigPositieveWaarde = ongeldigPositieveWaarde;
        }
    }

    public class OngeldigNegatieveWaardeException : Exception
    {
        private decimal ongeldigNegatieveWaardeValue;

        public decimal OngeldigNegatieveWaarde
        {
            get
            {
                return ongeldigNegatieveWaardeValue;
            }
            set
            {
                ongeldigNegatieveWaardeValue = value;
            }
        }

        public OngeldigNegatieveWaardeException(string message, decimal ongeldigNegatieveWaarde) : base(message)
        {
            OngeldigNegatieveWaarde = ongeldigNegatieveWaarde;
        }
    }
}
