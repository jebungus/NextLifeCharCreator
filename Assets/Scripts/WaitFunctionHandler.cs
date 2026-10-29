using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitFunctionHandler : MonoBehaviour
{
    public float delay = 0.2f;

    // Start is called before the first frame update
    public void StartDelay()
    {
        StartCoroutine(waitDelay(delay));
    }

    IEnumerator waitDelay(float d)
    {
        yield return new WaitForSeconds(d);
    }
}
