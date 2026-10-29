using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStyleSelector : MonoBehaviour
{
    
    public Sprite[] characters;
    public Sprite[] clothes;
    public Sprite[] hairs;
    public Sprite[] accessories;


    public Image charImg;
    public Image clothImg;
    public Image hairImg;
    public Image accImg;

    public AudioSource audSource;

    //all options default to 0
    private int charIndex=0;
    private int clothIndex=0;
    private int hairIndex=0;
    private int accIndex=0;

    void Start() {
        DisplaySelected();
    }


    public void setCharItem(int item, int n)
    {
        switch (item)
        {
            case 0:
                charIndex = n; break;
            case 1:
                clothIndex = n; break;
            case 2:
                hairIndex = n; break;
            case 3:
                accIndex = n; break;
            default:
                Debug.LogWarning("Invalid Outfit Item in switch statement");
                break;

        }
    
        DisplaySelected();
    }

    public void incrementCharItem(int item)
    {
        switch (item)
        {
            case 0:
                if (charIndex < (characters.Length - 1))
                { charIndex++; }
                break;
            case 1:
                if (clothIndex < (clothes.Length - 1))
                { clothIndex++; } 
                break;
            case 2:
                if (hairIndex < (hairs.Length - 1))
                { hairIndex++; }
                break;
            case 3:
                if (accIndex < (accessories.Length - 1))
                { accIndex++; }
                break;
            default:
                Debug.LogWarning("Invalid Outfit Item in switch statement");
                break;

        }

        if (audSource) { audSource.Play(); }

        DisplaySelected();
    }

    public void decrementCharItem(int item)
    {
        switch (item)
        {
            case 0:
                if (charIndex > 0)
                { charIndex--; }
                break;
            case 1:
                if (clothIndex > 0)
                { clothIndex--; }
                break;
            case 2:
                if (hairIndex > 0)
                { hairIndex--; }
                break;
            case 3:
                if (accIndex > 0)
                { accIndex--; }
                break;
            default:
                Debug.LogWarning("Invalid Outfit Item in switch statement");
                break;

        }

        if (audSource) { audSource.Play(); }
        DisplaySelected();
    }






    public void DisplaySelected()
    {
        charImg.sprite = characters[charIndex];
        clothImg.sprite = clothes[clothIndex];
        hairImg.sprite = hairs[hairIndex];
        accImg.sprite = accessories[accIndex];
    }


}
