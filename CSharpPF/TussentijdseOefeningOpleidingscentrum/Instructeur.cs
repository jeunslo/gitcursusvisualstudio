using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opleiding.Personeel
{
    public sealed class Instructeur : PersoneelslidV2
    {
        public class OngeldigEmailadressException : Exception
        {
            private string ongeldigEmailValue;

            public string OngeldigEmail
            {
                get
                {
                    return ongeldigEmailValue;
                }
                set
                {
                    ongeldigEmailValue = value;
                }
            }

            public OngeldigEmailadressException(string message, string ongeldigEmail) : base(message)
            {
                OngeldigEmail = ongeldigEmail;
            }
        }

        private Vakgebieden vakgebiedValue;
        private string emailValue;

        public Instructeur(string familienaam, string voornaam, decimal bruto, /*VerlofPeriodeV2 verlofperiode1, VerlofPeriodeV2 verlofperiode2, */Vakgebieden vakgebied, string email) : base(familienaam, voornaam, bruto/*, verlofperiode1, verlofperiode2*/)
        {
            Vakgebied = vakgebied;
            Email = email;
        }

        public Vakgebieden Vakgebied
        {
            get
            {
                return vakgebiedValue;
            }
            set
            {
                vakgebiedValue = value;
            }
        }

        public string Email
        {
            get
            {
                return emailValue;
            }
            set
            {
                if (EmailGeldigheid(value))
                    emailValue = value;
                else
                   throw new OngeldigEmailadressException("Ongeldig e-mailadres", value);
            }
        }

        public override void GegevensTonen()
        {
            base.GegevensTonen();
            Console.WriteLine("Vakgebied: {0}", Vakgebied);
            Console.WriteLine("E-mailadres: {0}", Email);
        }

        public bool EmailGeldigheid(string email)
        {
            return email.Contains('@') ? true : false;                
        }
    }
}
