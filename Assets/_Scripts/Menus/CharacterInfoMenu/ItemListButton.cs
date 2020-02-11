using System.Collections;
using System.Collections.Generic;
using _Scripts.Data;
using UnityEngine;
using UnityEngine.UI;

public class ItemListButton : MonoBehaviour {

    [SerializeField]
    private Text buttonText;

    [SerializeField]
    private ItemListController itemController;
    private string buttonTextString;
    private string descriptionText;
    public void SetText(string textString, string descriptionTextString) {
        buttonTextString = textString;
        buttonText.text = textString;
        descriptionText = descriptionTextString;
    }

    public void OnClick() {
        itemController.ButtonClicked(buttonTextString, descriptionText);
    }
}