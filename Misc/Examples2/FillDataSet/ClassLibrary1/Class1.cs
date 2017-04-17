using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OracleClient;
using System.Web.Configuration;
using System.Data;

namespace ClassLibrary1
{
    public class Class1
    {
        private string connectionstring;
        public Class1()
        {
            connectionstring = WebConfigurationManager.ConnectionStrings["mydb"].ConnectionString;
        }
        public DataSet FillDataSet(OracleCommand cmd, string table)
        {
            OracleConnection con = new OracleConnection(connectionstring);
            cmd.Connection = con;
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            {
                try
                {
                    con.Open();
                    da.Fill(ds, "mytable");
                }
                finally
                {
                    con.Close();
                }
                return ds;
            }
        }
        public DataSet getuid()
        {
            string select = "select DD_DICTATIONID,DD_TRANSCRIPTID,DD_FILENAME,DD_OWNER,DD_DICTATIONDATE,DD_DOCSTATUS,DD_STAT,DD_TIMEDUEBACK from as_dictationdtls  where rownum<=100";
            OracleCommand cmd = new OracleCommand(select);
            return FillDataSet(cmd, "mytable");
        }
    }
}
