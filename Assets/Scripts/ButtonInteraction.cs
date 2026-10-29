using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonInteraction : MonoBehaviour
{
    public Button startButton;
    public TMP_InputField nameField;

    // Update is called once per frame
    void Update()
    {
        if(nameField.text!= "")
        {
            startButton.interactable = true;
        }
        else
        {
            startButton.interactable = false;
        }
    }
}
