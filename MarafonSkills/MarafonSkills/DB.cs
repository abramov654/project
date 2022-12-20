using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarafonSkills
{
    public static class Util
    {
        private MarathonSkillsEntities database;
        public static MarathonSkillsEntities db
        {
            get
            {
                if (database == null)
                    database = new MarathonSkillsEntities();

                return database;
            }
        }
    }
}
