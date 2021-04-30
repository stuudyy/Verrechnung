using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;


namespace Verrechnung
{
    class Datenbank
    {
        //private SqlConnection verbindung;
        //private SqlCommand cmd;
        private OleDbConnection verbindung;
        private OleDbCommand cmd;
        private string cn;

        public Datenbank()
        {
            //cn =datasource=127.0.0.1;port=3306;username=root;password=;database=test;";
            cn = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = Verrechnung.accdb";
            verbindung = new OleDbConnection(cn);
            verbindung.Open();
        }

        public OleDbDataReader Einlesen(string sql)
        {
            try
            {
                //verbindung.Open();
                cmd = new OleDbCommand(sql, verbindung);
                return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Einlesen " + ex.Message);
            }
            //finally
            //{
            //    verbindung.Close();
            //}
        }

        public void Ausführen(string sql)
        {
            try
            {
                // verbindung.Open();
                cmd = new OleDbCommand(sql, verbindung);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Einlesen " + ex.Message);
            }
            //finally
            //{
            //    verbindung.Close();
            //}
        }

        public Int32 BerechnenInt(string sql)
        {
            try
            {
                cmd = new OleDbCommand(sql, verbindung);
                return (Int32)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Berechnen mit Int " + ex.Message);
            }
            
        }
        
    }
}
