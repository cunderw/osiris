using System.Data;
using System.IO;
using Mono.Data.Sqlite;
using UnityEngine;

namespace _Scripts.Data {
    public class ItemData {
        private static string connection = "URI=file:" + Application.streamingAssetsPath + "/dbs/items_db";

        public WeaponData GetWeaponData(string weapon_id) {
            IDbConnection dbcon = new SqliteConnection(connection);
            dbcon.Open();
            IDbCommand dbcmd = dbcon.CreateCommand();
            dbcmd.CommandText = "SELECT * FROM weapons WHERE weapon_id = '" + weapon_id + "'";
            IDataReader reader = dbcmd.ExecuteReader();
            WeaponData data = new WeaponData(reader);
            dbcon.Close();
            string logString = "[ItemData.GetWeaponData]\n";
            logString += "id\t|\tname\t|\tdescription\t|\tdamage\t|\trate\t|\tvalue\t|\tslots\n";
            logString += data.weapon_id + "\t|\t" + data.weapon_name + "\t|\t" + data.weapon_description + "\t|\t" + data.weapon_damage + "\t|\t" + data.weapon_attack_rate + "\t|\t" + data.weapon_value + "\t|\t" + data.weapon_slots;
            Debug.Log(logString);
            return data;
        }
    }

    public class WeaponData {
        public string weapon_id;
        public string weapon_name;
        public string weapon_description;
        public int weapon_damage;
        public int weapon_attack_rate;
        public int weapon_value;
        public int weapon_slots;
        public WeaponData(IDataReader reader) {
            weapon_id = reader[0].ToString();
            weapon_name = reader[1].ToString();
            weapon_description = reader[2].ToString();
            weapon_damage = int.Parse(reader[3].ToString());
            weapon_attack_rate = int.Parse(reader[4].ToString());
            weapon_value = int.Parse(reader[5].ToString());
            weapon_slots = int.Parse(reader[6].ToString());
        }
    }
}