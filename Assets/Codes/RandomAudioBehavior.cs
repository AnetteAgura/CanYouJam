using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class RandomAudioBehavior: MonoBehaviour
{

    public AudioSource randomSound;

    public AudioClip[] audioSources;

    // Use this for initialization
    void Start()
    {
        
        StartCoroutine(AudioGenerator());
    }


    IEnumerator AudioGenerator()
    {

        yield return new WaitForSeconds(20);
        StartCoroutine(Generate());
    }

    IEnumerator Generate()
    {

        yield return new WaitForSeconds(10);
        randomSound.clip = audioSources[Random.Range(0, audioSources.Length)];
        randomSound.Play();
        StartCoroutine(Generate());
    }


}