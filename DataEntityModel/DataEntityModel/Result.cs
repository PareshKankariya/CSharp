using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntityModel
{
    class Result
    {
        public String result()
        {
            LocalADWorksDataContext db = new LocalADWorksDataContext();

            if (db.DatabaseExists())
            {


                //Debug.WriteLine("Database ALREADY Exists");

                var q = from a in db.Persons.Where(x => x.LastName.StartsWith("Anderson"))
                        select a;
                return q.ToString();
                //     db.Log = System.Console.Out;
          
                //foreach (var r in q)
                //{
                //    Console.WriteLine();
                //}





            }
            else
                return null;
        }
    }
}

