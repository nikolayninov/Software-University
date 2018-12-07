using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier {
    public class DateModifier {
        private int difference;
        public int Difference {
            get { return this.difference; }
        }
        public DateModifier (DateTime first, DateTime second) {
            this.difference = Math.Abs ((first - second).Days);
        }
    }
}