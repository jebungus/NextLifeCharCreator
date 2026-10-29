using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TeleType : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI pressNextText;
    public string[] sentences;
    
    private int sentenceIndex = 0;
    public float letterDelay = 0.05f;
    public AudioSource adSourceType;
    public AudioSource adSourceNext;
    private bool doneWriting = false;
    public Button nextSceneButton;

    public void Start()
    {
        dialogueText.text = sentences[sentenceIndex];
        dialogueText.maxVisibleCharacters = 0;
        pressNextText.gameObject.SetActive(false);
        StartCoroutine(WriteSentence());
    }

    

    void Update()
    {
        

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0)) && doneWriting && sentenceIndex != sentences.Length - 1)
        {
            sentenceIndex++;
            pressNextText.gameObject.SetActive(false);
            dialogueText.maxVisibleCharacters = 0;
            StopCoroutine(WriteSentence());
            doneWriting = false;
            NextSentence();

        }
    }


    void NextSentence()
    {
        if (sentenceIndex <= sentences.Length - 1)
        {
            if (sentenceIndex == sentences.Length - 1)
            {
                nextSceneButton.gameObject.SetActive(true);
            }
            adSourceNext.Play();
            dialogueText.text = sentences[sentenceIndex];
            //maybe stop and start coroutine?
            //seems like clicking mid text is making full next sentence visible on screen
            StartCoroutine(WriteSentence());
        }
    }

    IEnumerator WriteSentence()
    {
        
        int totalVisibleChars = dialogueText.text.Length;
        //Debug.Log(totalVisibleChars);
        

        for (int i = 0; i <= totalVisibleChars; i++) 
        {
            
            int visibleCount = i % (totalVisibleChars + 1);

            dialogueText.maxVisibleCharacters = i;


         

            //make a sound for each letter
            adSourceType.pitch = Random.Range(1.3f, 2f);
            adSourceType.Play();
            

            yield return new WaitForSeconds(letterDelay);

            if(dialogueText.maxVisibleCharacters == totalVisibleChars)
            {
                if (sentenceIndex < sentences.Length - 1)
                {
                    yield return new WaitForSeconds(0.5f);
                    pressNextText.gameObject.SetActive(true);
                }
                doneWriting = true;
            }


        }
    }




    
}
