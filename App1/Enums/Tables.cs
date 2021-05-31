using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1.Enums
{
    public class Tables
    {
        private Tables(string value) { Value = value; }

        public string Value { get; private set; }

        public static Tables Client { get { return new Tables("Client"); } }
        public static Tables Dogovor { get { return new Tables("Dogovor"); } }
        public static Tables Kurs { get { return new Tables("Kurs"); } }
        public static Tables Organizatsia { get { return new Tables("Organizatsia"); } }
        public static Tables Prepodavateli { get { return new Tables("Prepodavateli"); } }
    }
}
