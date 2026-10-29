using UnityEngine;

public class UpdateVolume : MonoBehaviour
{
    
    
    
    public void changeVolume(float volume)
    {
        NameSystem.globalVolume = volume;
        Debug.Log("Global Volume: " + NameSystem.globalVolume);
    }
}
