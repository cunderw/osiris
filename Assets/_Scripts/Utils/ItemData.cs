using System.Data;
using System.IO;

using Mono.Data.Sqlite;

using UnityEngine;

namespace _Scripts.Data {
    public class ItemData {
        private static string connection = "URI=file:" + Application.streamingAssetsPath + "/dbs/items_db";

        public WeaponData GetWeaponData(string weapon_id) {
            IDbConnection dbcon = new SqliteConnection(connection);
            IDbCommand dbcmd = dbcon.CreateCommand();
            dbcmd.CommandText = "SELECT * FROM weapons WHERE weapon_id = " + weapon_id;
            IDataReader reader = dbcmd.ExecuteReader();
            WeaponData data = new WeaponData(reader);
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

        }
    }
}
