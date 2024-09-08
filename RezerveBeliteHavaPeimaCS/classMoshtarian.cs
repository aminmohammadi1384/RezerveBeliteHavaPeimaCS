using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace RezerveBeliteHavaPeimaCS
{
    class classMoshtarian
    {
        

        private DataTable mostarian()
        {
            FirstClass db = new FirstClass();
            DataTable dt = new DataTable();

            dt = db.dbOut("SELECT     TOP 100 PERCENT CustomerID, NameSname, PhoneNum, FaxNum, Notes FROM        Custumers  ORDER BY CustomerID");
            return dt;
        }

    }

   
}
