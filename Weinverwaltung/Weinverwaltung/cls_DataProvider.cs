using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Weinverwaltung
{
    internal class cls_DataProvider
    {
        const string CONNECTIONSTRING = "Server=127.0.0.1;Database=db_weinverwaltung;Uid=root;Pwd=;";

        internal static UInt32 Weinlager(int spalte, int fach)
        {
            using (MySqlConnection conn = new MySqlConnection(CONNECTIONSTRING))
            {
                string sql = "SELECT ID_Artikel FROM tbl_regalplatz WHERE Fach = @fach AND Spalte = @spalte AND ID_Artikel != 0";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@fach", MySqlDbType.Int32).Value = fach;
                cmd.Parameters.Add("@spalte", MySqlDbType.Int32).Value = spalte;
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    uint id = Convert.ToUInt32(reader["ID_Artikel"]);
                    return id;
                }
                conn.Close();
            }
            return 0;
        }
        internal static cls_Fach WeinAnzeigen(uint id)
        {
            cls_Fach fach = new cls_Fach();
            using (MySqlConnection conn = new MySqlConnection(CONNECTIONSTRING))
            {
                string sql = "Select tbl_artikel.Alkoholgehalt, tbl_artikel.Notizen, tbl_artikel.Bezeichnung, tbl_artikel.Liter, tbl_artikel.Jahrgang, tbl_weingut.Name, tbl_sorte.Bezeichnung As Sorte From tbl_artikel Inner Join tbl_sorte On tbl_artikel.ID_Sorte = tbl_sorte.ID Inner Join tbl_weingut On tbl_artikel.ID_Weingut = tbl_weingut.ID Inner Join tbl_regalplatz On tbl_regalplatz.ID_Artikel = tbl_artikel.ID Where tbl_regalplatz.ID_Artikel = @id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@id", MySqlDbType.UInt32).Value = id;
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    fach.Wein = new cls_Wein();
                    fach.Wein.Alkoholgehalt = Convert.ToDecimal(reader["Alkoholgehalt"]);
                    fach.Wein.Notizen = Convert.ToString(reader["Notizen"]);
                    fach.Wein.Bezeichnung = Convert.ToString(reader["Bezeichnung"]);
                    fach.Wein.Liter = Convert.ToDouble(reader["Liter"]);
                    fach.Wein.Jahrgang = Convert.ToInt32(reader["Jahrgang"]);
                    fach.Weingutname = Convert.ToString(reader["Name"]);
                    fach.Sorte = Convert.ToString(reader["Sorte"]);
                }
                conn.Close();
                return fach;
            }
        }
        internal static void NeuesWeingut(cls_Weingut weingut)
        {
            using (MySqlConnection conn = new MySqlConnection(CONNECTIONSTRING))
            {
                string sql = "INSERT INTO tbl_weingut (Name, Strasse, PLZ, Ort, EMail, Telefon) values (@name, @strasse, @plz, @ort, @email, @tel)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = weingut.Name;
                cmd.Parameters.Add("@strasse", MySqlDbType.VarChar).Value = weingut.Strasse;
                cmd.Parameters.Add("@plz", MySqlDbType.VarChar).Value = weingut.PLZ;
                cmd.Parameters.Add("@ort", MySqlDbType.VarChar).Value = weingut.Ort;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = weingut.EMail;
                cmd.Parameters.Add("@tel", MySqlDbType.VarChar).Value = weingut.Telefon;
                conn.Open();
                cmd.ExecuteNonQuery();
                weingut.ID = Convert.ToUInt32(cmd.LastInsertedId);
                conn.Close();
            }
        }
        internal static void WeingutAendern(cls_Weingut weingut)
        {
            using (MySqlConnection conn = new MySqlConnection(CONNECTIONSTRING))
            {
                string sql = "UPDATE tbl_weingut SET Name = @name, Strasse = @strasse, PLZ = @plz, Ort = @ort, EMail = @email, Telefon = @tel WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = weingut.Name;
                cmd.Parameters.Add("@strasse", MySqlDbType.VarChar).Value = weingut.Strasse;
                cmd.Parameters.Add("@plz", MySqlDbType.VarChar).Value = weingut.PLZ;
                cmd.Parameters.Add("@ort", MySqlDbType.VarChar).Value = weingut.Ort;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = weingut.EMail;
                cmd.Parameters.Add("@tel", MySqlDbType.VarChar).Value = weingut.Telefon;
                cmd.Parameters.Add("@id", MySqlDbType.UInt32).Value = weingut.ID;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        internal static void WeingutLoeschen(cls_Weingut weingut)
        {
            using (MySqlConnection conn = new MySqlConnection(CONNECTIONSTRING))
            {
                string sql = "DELETE FROM tbl_weingut WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@id", MySqlDbType.UInt32).Value = weingut.ID;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        internal static List<cls_Weingut> AlleWeingueterAnzeigen()
        {
            List<cls_Weingut> returnList = new List<cls_Weingut>();
            using (MySqlConnection conn = new MySqlConnection(CONNECTIONSTRING))
            {
                string sql = "SELECT * FROM tbl_weingut ORDER BY Name";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cls_Weingut weingut = new cls_Weingut();
                    weingut.ID = Convert.ToUInt32(reader["ID"]);
                    weingut.Name = Convert.ToString(reader["Name"]);
                    weingut.Strasse = Convert.ToString(reader["Strasse"]);
                    weingut.PLZ = Convert.ToString(reader["PLZ"]);
                    weingut.Ort = Convert.ToString(reader["Ort"]);
                    weingut.EMail = Convert.ToString(reader["EMail"]);
                    weingut.Telefon = Convert.ToString(reader["Telefon"]);
                    returnList.Add(weingut);
                }
                conn.Close();
            }
            return returnList;
        }
        internal static List<cls_Sorte> AlleSortenAnzeigen()
        {
            List<cls_Sorte> returnList = new List<cls_Sorte>();
            using (MySqlConnection conn = new MySqlConnection(CONNECTIONSTRING))
            {
                string sql = "SELECT * FROM tbl_sorte ORDER BY Bezeichnung";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cls_Sorte sorte = new cls_Sorte();
                    sorte.ID = Convert.ToUInt32(reader["ID"]);
                    sorte.Bezeichnung = Convert.ToString(reader["Bezeichnung"]);
                    returnList.Add(sorte);
                }
                conn.Close();
            }
            return returnList;
        }
        internal static List<cls_Wein> AlleWeineAnzeigen()
        {
            List<cls_Wein> returnList = new List<cls_Wein>();
            using (MySqlConnection conn = new MySqlConnection(CONNECTIONSTRING))
            {
                string sql = "SELECT tbl_artikel.*, tbl_sorte.Bezeichnung As Sorte, tbl_weingut.Name FROM tbl_artikel Inner Join tbl_sorte On tbl_artikel.ID_Sorte = tbl_sorte.ID Inner Join tbl_weingut On tbl_artikel.ID_Weingut = tbl_weingut.ID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cls_Wein wein = new cls_Wein();
                    wein.ID = Convert.ToUInt32(reader["ID"]);
                    wein.Bezeichnung = Convert.ToString(reader["Bezeichnung"]);
                    wein.Alkoholgehalt = Convert.ToDecimal(reader["Alkoholgehalt"]);
                    wein.Notizen = Convert.ToString(reader["Notizen"]);
                    wein.Einzelpreis = Convert.ToDouble(reader["Einzelpreis"]);
                    wein.Liter = Convert.ToDouble(reader["Liter"]);
                    wein.Jahrgang = Convert.ToInt32(reader["Jahrgang"]);
                    wein.ID_Weingut = Convert.ToUInt32(reader["ID_Weingut"]);
                    wein.ID_Sorte = Convert.ToUInt32(reader["ID_Sorte"]);
                    wein.Sorte = Convert.ToString(reader["Sorte"]);
                    wein.Weingutname = Convert.ToString(reader["Name"]);
                    returnList.Add(wein);
                }
                conn.Close();
            }
            return returnList;
        }
        internal static List<cls_Wein> WeinMenge()
        {
            int eingelagert;
            List<cls_Wein> returnList = new List<cls_Wein>();
            using (MySqlConnection conn = new MySqlConnection(CONNECTIONSTRING))
            {
                string sql = "SELECT tbl_artikel.ID, tbl_artikel.Bezeichnung, tbl_artikel.Jahrgang, tbl_artikel.Menge, tbl_sorte.Bezeichnung As Sorte, tbl_weingut.Name FROM tbl_artikel Inner Join tbl_sorte On tbl_artikel.ID_Sorte = tbl_sorte.ID Inner Join tbl_weingut On tbl_artikel.ID_Weingut = tbl_weingut.ID";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cls_Wein wein = new cls_Wein();
                    wein.ID = Convert.ToUInt32(reader["ID"]);
                    wein.Bezeichnung = Convert.ToString(reader["Bezeichnung"]);
                    wein.Jahrgang = Convert.ToInt32(reader["Jahrgang"]);
                    eingelagert = EingelagerterWein(wein.ID);
                    wein.Menge = Convert.ToInt32(reader["Menge"]) - eingelagert;
                    wein.Sorte = Convert.ToString(reader["Sorte"]);
                    wein.Weingutname = Convert.ToString(reader["Name"]);
                    if (wein.Menge > 0)
                        returnList.Add(wein);
                }
                conn.Close();
            }
            return returnList;
        }
        internal static int EingelagerterWein(uint id)
        {
            int menge = 0;
            using (MySqlConnection conn = new MySqlConnection(CONNECTIONSTRING))
            {
                string sql = "SELECT COUNT(*) FROM tbl_regalplatz WHERE ID_Artikel = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@id", MySqlDbType.UInt32).Value = id;
                conn.Open();
                menge = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
            }
            return menge;
        }
        internal static void NeuerWein(cls_Wein wein)
        {
            using (MySqlConnection conn = new MySqlConnection(CONNECTIONSTRING))
            {
                string sql = "INSERT INTO tbl_artikel (Alkoholgehalt, Einzelpreis, Bezeichnung, Liter, Jahrgang, Menge, ID_Weingut, ID_Sorte) values (@gehalt, @preis, @bez, @liter, @jahr, @menge, @idwg, @idsorte)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@gehalt", MySqlDbType.Decimal).Value = wein.Alkoholgehalt;
                cmd.Parameters.Add("@preis", MySqlDbType.Double).Value = wein.Einzelpreis;
                cmd.Parameters.Add("@bez", MySqlDbType.VarChar).Value = wein.Bezeichnung;
                cmd.Parameters.Add("@liter", MySqlDbType.Double).Value = wein.Liter;
                cmd.Parameters.Add("@jahr", MySqlDbType.Int32).Value = wein.Jahrgang;
                cmd.Parameters.Add("@menge", MySqlDbType.Int32).Value = wein.Menge;
                cmd.Parameters.Add("@idwg", MySqlDbType.UInt32).Value = wein.ID_Weingut;
                cmd.Parameters.Add("@idsorte", MySqlDbType.UInt32).Value = wein.ID_Sorte;
                conn.Open();
                cmd.ExecuteNonQuery();
                wein.ID = Convert.ToUInt32(cmd.LastInsertedId);
                conn.Close();
            }
        }
        internal static void VorhandenerWein(int menge, uint id)
        {
            using (MySqlConnection conn = new MySqlConnection(CONNECTIONSTRING))
            {
                string sql = "UPDATE tbl_artikel SET Menge = @menge WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@id", MySqlDbType.UInt32).Value = id;
                cmd.Parameters.Add("@menge", MySqlDbType.VarChar).Value = menge + Menge(id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        internal static int Menge(uint id)
        {
            int menge = 0;
            using (MySqlConnection conn = new MySqlConnection(CONNECTIONSTRING))
            {
                string sql = "SELECT Menge FROM tbl_artikel WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@id", MySqlDbType.UInt32).Value = id;
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    menge = Convert.ToInt32(reader["Menge"]);
                }
                conn.Close();
            }
            return menge;
        }
        internal static int FreierPlatz()
        {
            int menge = 0;
            using (MySqlConnection conn = new MySqlConnection(CONNECTIONSTRING))
            {
                string sql = "SELECT COUNT(*) FROM tbl_regalplatz WHERE ID_Artikel IS NULL";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                menge = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
            }
            return menge;
        }
        internal static void Einlagern(uint id_wein, int spalte, int fach)
        {
            using (MySqlConnection conn = new MySqlConnection(CONNECTIONSTRING))
            {
                string sql = "UPDATE tbl_regalplatz SET ID_Artikel = @id_wein WHERE Fach = @fach AND Spalte = @spalte";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@id_wein", MySqlDbType.UInt32).Value = id_wein;
                cmd.Parameters.Add("@fach", MySqlDbType.Int32).Value = fach;
                cmd.Parameters.Add("@spalte", MySqlDbType.Int32).Value = spalte;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        internal static void NotizAendern(string notiz, uint id)
        {
            using (MySqlConnection conn = new MySqlConnection(CONNECTIONSTRING))
            {
                string sql = "UPDATE tbl_artikel SET Notizen = @notiz WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@id", MySqlDbType.UInt32).Value = id;
                cmd.Parameters.Add("@notiz", MySqlDbType.VarChar).Value = notiz;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        internal static string NotizAnzeigen(uint id)
        {
            string notiz = "";
            using (MySqlConnection conn = new MySqlConnection(CONNECTIONSTRING))
            {
                string sql = "SELECT Notizen FROM tbl_artikel WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@id", MySqlDbType.UInt32).Value = id;
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    notiz = Convert.ToString(reader["Notizen"]);
                }
                conn.Close();
            }
            return notiz;
        }
        internal static void WeinKonsumieren(int spalte, int fach)
        {
            using (MySqlConnection conn = new MySqlConnection(CONNECTIONSTRING))
            {
                string sql = "UPDATE tbl_regalplatz SET ID_Artikel = null WHERE Fach = @fach AND Spalte = @spalte";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.Add("@fach", MySqlDbType.Int32).Value = fach;
                cmd.Parameters.Add("@spalte", MySqlDbType.Int32).Value = spalte;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close(); ;
            }
        }
    }
}
