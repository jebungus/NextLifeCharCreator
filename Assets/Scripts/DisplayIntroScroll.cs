using UnityEngine;

public class DisplayIntroScroll : MonoBehaviour
{
    public GameObject dc;
    private TeleType tele;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        tele= dc.GetComponent<TeleType>();
        if (NameSystem.GetPlayerName() == "")
        {
            tele.sentences[0] = "Hello, [Player]";
        }
        else
        {
            tele.sentences[0] = "Hello, " + NameSystem.GetPlayerName();
        }
        Debug.Log(tele.sentences[0]);
    }

    
}
