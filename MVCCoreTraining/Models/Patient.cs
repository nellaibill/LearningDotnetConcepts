using System.Collections.Generic;

namespace MVCCoreTraining.Models
{
    public class Patient
    {
        public int id { get; set; }

        public string patientName { get; set; }

        public List<Problem> problems { get; set; }
    }

    public class Problem
    {
        public int id { get; set; }

        public string description { get; set; }
    }
}
