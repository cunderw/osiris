using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemListController : MonoBehaviour {

    [SerializeField]
    private GameObject buttonTemplate;

    void Start() {
        BuildList();
    }

    private void BuildList() {
        for (int i = 0; i < 20; i++) {
            Debug.Log("Adding Button " + 1);
            GameObject button = Instantiate(buttonTemplate) as GameObject;

            button.SetActive(true);

            button.GetComponent<ItemListButton>().SetText("Item - " + i);

            button.transform.SetParent(buttonTemplate.transform.parent, false);
        }

    }

}