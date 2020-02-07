using System.Collections;
using System.Collections.Generic;
using _Scripts.Data;
using UMA;
using UMA.CharacterSystem;
using UnityEngine;
using UnityEngine.UI;
public class ItemListController : MonoBehaviour {

    [SerializeField]
    private GameObject buttonTemplate;

    [SerializeField]
    private int[] intArray;
    private List<GameObject> itemButtons;
    private CharacterInventoryData inventoryData;
    private List<CharacterWeaponData> weaponData;

    void Start() {
        inventoryData = new CharacterInventoryData();
        weaponData = inventoryData.GetChatacterWeaponData();
        BuildList();

    }

    private void BuildList() {
        itemButtons = new List<GameObject>();
        // check to see if we already have buttons and destroy them before rebuilding
        if (itemButtons.Count > 0) {
            foreach (GameObject button in itemButtons) {
                Destroy(button);
            }

            itemButtons.Clear();
        }

        // build the list ofitem buttons
        foreach (CharacterWeaponData data in weaponData) {
            GameObject button = Instantiate(buttonTemplate) as GameObject;

            button.SetActive(true);

            button.GetComponent<ItemListButton>().SetText(data.weapon_name);

            button.transform.SetParent(buttonTemplate.transform.parent, false);

            itemButtons.Add(button);

        }

    }

    public void ButtonClicked(string buttonTextString) {
        Debug.Log("[ItemListController] - Selected Item: " + buttonTextString);
    }
}