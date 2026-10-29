using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetAfter10s : MonoBehaviour
{
    GameObject resetController;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       GetComponent<Control>().StartDelay();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            GetComponent<Control>().NextScene();

        }
            
    }

}
