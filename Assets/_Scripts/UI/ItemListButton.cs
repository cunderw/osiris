using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemListButton : MonoBehaviour {

    [SerializeField]
    private Text buttonText;
    public void SetText(string textString) {
        buttonText.text = textString;
    }

    public void OnClick() {

    }
}