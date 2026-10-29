using UnityEngine;
using UnityEngine.UI;

public class CreatorButtonControl : MonoBehaviour
{
    public GameObject[] controlItems; //Array of items to be turned on/off on button click
    public GameObject[] confirmItems; //Array of items to be turned on/off on button click
    public Button enterButton; //Reference to the button that will trigger the action

    public void deactivateItems()
    {
        foreach (GameObject item in controlItems)
        {
            item.SetActive(false); //Deactivate each item in the array
        }
        foreach (GameObject item in confirmItems)
        {
            item.SetActive(true); //activate each item in the array
        }
    }

    public void activateItems()
    {
        foreach (GameObject item in controlItems)
        {
            item.SetActive(true); //Activate each item in the array
        }
        foreach (GameObject item in confirmItems)
        {
            item.SetActive(false); //Deactivate each item in the array
        }
    }

    
}
