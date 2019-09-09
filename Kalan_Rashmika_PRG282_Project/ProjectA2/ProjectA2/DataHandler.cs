using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA2
{
    class DataHandler
    {
        public static List<Jets> GetJet()
        {
            List<Jets> jet = new List<Jets>();
            SqlConnection conn = new SqlConnection("Data Source= Laptop-FV2K7HFU; Initial Catalog=ProjectAT1; Integrated Security=SSPI");
            conn.Open();
            SqlDataReader rdr = null;
            SqlCommand cmd = new SqlCommand("Select * from tblJet", conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                jet.Add(new Jets(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString()));
            }
            cmd.Dispose();
            conn.Close();
            return jet;
        } //reads the database and returns a list of type Jets
        public static void Insert(Jets J)
        {
            SqlConnection conn = new SqlConnection("Data Source= Laptop-FV2K7HFU; Initial Catalog=ProjectAT1; Integrated Security=SSPI");
            conn.Open();
            string insert = @"insert into tblJet(JetID, Name, TopSpeed, FuelTankSize, InventoryCapacity, TypeOfweapons, MaximumAltitude)
                            values(@ji, @name, @ts, @fts, @mc, @tw, @ma)";
            using (SqlCommand cmi = new SqlCommand(insert, conn))
            {
                cmi.Parameters.AddWithValue("@ji", J.JetID);
                cmi.Parameters.AddWithValue("@name", J.Name);
                cmi.Parameters.AddWithValue("@ts", J.TopSpeed);
                cmi.Parameters.AddWithValue("@fts", J.FuelTankSize);
                cmi.Parameters.AddWithValue("@mc", J.InventoryCapacity);
                cmi.Parameters.AddWithValue("@tw", J.TypeOfWeapons);
                cmi.Parameters.AddWithValue("@ma", J.MaximumAltitude);
                cmi.ExecuteNonQuery();
            }
        } //Inserts a new jet into the database using info supplied by the user

        public void DeleteJet(string name)
        {
            SqlConnection conn = new SqlConnection("Data Source= Laptop-FV2K7HFU; Initial Catalog=ProjectAT1; Integrated Security=SSPI");
            conn.Open();
            string command = @"Delete from tblJet where Name LIKE @Name";
            using (SqlCommand cmd=new SqlCommand(command,conn))
            {
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        } //deletes a jet from the database

        public void Update(Jets j)
        {
            SqlConnection conn = new SqlConnection("Data Source= Laptop-FV2K7HFU; Initial Catalog=ProjectAT1; Integrated Security=SSPI");
            conn.Open();
            string command = @"Update tblJet SET Name=@Name, TopSpeed=@Speed, FuelTankSize=@Tank, InventoryCapacity=@In, TypeOfWeapons=@type, MaximumAltitude=@Max WHERE JetID LIKE @Old";
            using (SqlCommand cmu=new SqlCommand(command,conn))
            {
                cmu.Parameters.AddWithValue("@Old", j.JetID);
                cmu.Parameters.AddWithValue("@Name", j.Name);
                cmu.Parameters.AddWithValue("@Speed", j.TopSpeed);
                cmu.Parameters.AddWithValue("@Tank", j.FuelTankSize);
                cmu.Parameters.AddWithValue("@In", j.InventoryCapacity);
                cmu.Parameters.AddWithValue("@type", j.TypeOfWeapons);
                cmu.Parameters.AddWithValue("@Max", j.MaximumAltitude);
                cmu.ExecuteNonQuery();
            }
            conn.Close();
        } //updates a h=jet in the database using info supplied by the user

        public static void Report(Jets j, double time, double distance, double fuel, double ic, int ob, int en, double damage)
        {
            string fn= @"Report.txt";
            StreamWriter wrt = new StreamWriter(fn);
            using (wrt)
            {
                wrt.WriteLine("Time Of Simulation:\t{0}", DateTime.Now.ToString("yyyy/MM/dd h:mm tt"));
                wrt.WriteLine("-----------------------------------------------------------------");
                wrt.WriteLine("JetID:\t {0}", j.JetID);
                wrt.WriteLine("Name:\t {0}", j.Name);
                wrt.WriteLine("Distance of Shortest Path:\t {0} Km", distance);
                wrt.WriteLine("Obstacles Encountered: ");
                wrt.WriteLine("\t\t{0} Outposts", ob);
                wrt.WriteLine("\t\t{0} Enemy Camps", en);
                wrt.WriteLine("\t\t1 Mountain Range");
                wrt.WriteLine("\t\t1 Enemy Trench");
                wrt.WriteLine("\t\t1 Enemy Camp Wall");
                wrt.WriteLine("-----------------------------------------------------------------");
                wrt.WriteLine("Time Taken for Jet to reach enemy camp:\t{0} minutes", time);
                wrt.WriteLine("Fuel Left:\t {0}L", fuel);
                wrt.WriteLine("Inventory Left:\t {0}Kg", ic);
                wrt.WriteLine("Damage to Aircraft:\t {0}%", damage);
            }
        } //writes the report/results of the simulation to a textfile      
    }
}
