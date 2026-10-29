using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameSystem : MonoBehaviour
{
    

    public static string playerName = "";
    public static float globalVolume = 1.0f;

    public static void SavePlayerName(TMP_InputField nameField)
    {
        
        playerName = nameField.text;
        Debug.Log("Player Name: " + playerName);
    }

    public static string GetPlayerName()
    {
        return playerName;
    }

}
