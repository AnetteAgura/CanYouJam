using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicsoundcontrol : MonoBehaviour
{
    AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        

        StartCoroutine(thingy());
    }

    IEnumerator thingy()
    {
        yield return new WaitForSeconds(17);
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        Debug.Log("started");
    }
}
