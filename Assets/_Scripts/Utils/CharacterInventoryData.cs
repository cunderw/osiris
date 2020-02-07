using System.Collections.Generic;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;
using UnityEngine;

namespace _Scripts.Data {
    public class CharacterInventoryData {
        private static string connection = "URI=file:" + Application.streamingAssetsPath + "/dbs/default_character_db";
        private List<CharacterWeaponData> characterWeaponData;

        public List<CharacterWeaponData> GetChatacterWeaponData() {
            characterWeaponData = new List<CharacterWeaponData>();
            IDbConnection dbcon = new SqliteConnection(connection);
            dbcon.Open();
            IDbCommand dbcmd = dbcon.CreateCommand();
            dbcmd.CommandText = "SELECT * FROM inventory_weapons";
            IDataReader reader = dbcmd.ExecuteReader();
            while (reader.Read()) {
                CharacterWeaponData data = new CharacterWeaponData(reader[0].ToString(), int.Parse(reader[1].ToString()), int.Parse(reader[1].ToString()));
                characterWeaponData.Add(data);
            }

            dbcon.Close();
            return characterWeaponData;
        }
    }

    public class CharacterWeaponData {
        private ItemData itemData;
        public string weapon_id;
        public string weapon_name;
        public string weapon_description;
        public int weapon_damage;
        public int weapon_attack_rate;
        public int weapon_value;
        public int weapon_slots;
        public int weapon_qty;
        public int weapon_equiped;
        public CharacterWeaponData(string _weapon_id, int _weapon_qty, int _weapon_equiped) {
            itemData = new ItemData();
            WeaponData data = itemData.GetWeaponData(_weapon_id);
            weapon_id = _weapon_id;
            weapon_name = data.weapon_name;
            weapon_description = data.weapon_description;
            weapon_damage = data.weapon_damage;
            weapon_attack_rate = data.weapon_attack_rate;
            weapon_value = data.weapon_value;
            weapon_slots = data.weapon_slots;
            weapon_qty = _weapon_qty;
            weapon_equiped = _weapon_equiped;
        }
    }
}