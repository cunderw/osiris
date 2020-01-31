using System.Collections;
using System.Collections.Generic;
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

    void Start() {
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
        foreach (int i in intArray) {
            GameObject button = Instantiate(buttonTemplate) as GameObject;

            button.SetActive(true);

            button.GetComponent<ItemListButton>().SetText("Item - " + i);

            button.transform.SetParent(buttonTemplate.transform.parent, false);

            itemButtons.Add(button);

        }

    }

    public void ButtonClicked(string buttonTextString) {
        Debug.Log("[ItemListController] - Selected Item: " + buttonTextString);
    }
}