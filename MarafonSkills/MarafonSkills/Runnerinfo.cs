using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarafonSkills
{
    public class Runnerinfo
    {
        public Runner runner { get; set; }
        public string info
        {
            get
            {
                return string.Format("{0} {1} - {2} ({3})", runner.User.FirstName, runner.User.LastName, runner.CountryCode, runner.Contry.ContryName);
            }
        }
    }
}
