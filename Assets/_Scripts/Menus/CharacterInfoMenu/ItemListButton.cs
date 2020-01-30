using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemListButton : MonoBehaviour {

    [SerializeField]
    private Text buttonText;

    [SerializeField]
    private ItemListController itemController;
    private string buttonTextString;
    public void SetText (string textString) {
        buttonTextString = textString;
        buttonText.text = textString;
    }

    public void OnClick () {
        itemController.ButtonClicked (buttonTextString);
    }
}