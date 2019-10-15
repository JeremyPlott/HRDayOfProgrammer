using System;

namespace HRDayOfTheProgrammer {
    class Program {
        static void Main(string[] args) {

            int year = 2017;

            string d = "13.";
            string m = "09.";

            if (year == 1918) {
                d = "26.";
                return d + m + year;
            }
            if (year < 1918 && year % 4 == 0) {
                d = "12.";
            }
            if (year > 1918 && (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)) {
                d = "12.";
            }

            return d + m + year;
        }
    }
}
