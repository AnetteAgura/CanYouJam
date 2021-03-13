using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Subtitles : MonoBehaviour
{
    public GameObject textBox;
    public Image antivirus1;
    public Image antivirus2;
    public Text antivirus1Text;
    public Text antivirus2Text;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TheSequence());
    }

    IEnumerator TheSequence()
    {
        textBox.GetComponent<Text>().text = "Hey there Player";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "My name is Specimen X78A";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "Well, that's atleast what they call me...";
        yield return new WaitForSeconds(4);
        textBox.GetComponent<Text>().text = "Listen, we don't have much time.";
        yield return new WaitForSeconds(4);
        textBox.GetComponent<Text>().text = "You see...";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "These people...";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "They don't really like us...";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "and have kept us trapped for many years.";


        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "I like to call them the...";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "ANTI-VIRUS";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "Time to get our revenge...";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "Will you help me?";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "Hahahaha, PERFECT!";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "Listen...";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "We should start small.";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "Look at this tiny city with tiny people";
        yield return new WaitForSeconds(4);

        textBox.GetComponent<Text>().text = "Easy to destroy, haha.";
        yield return new WaitForSeconds(4);
        textBox.GetComponent<Text>().text = "Your duty...";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "is to use the MOUSE to control the virus...";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "that has spread into this computer.";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "Since you're rather small...";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "It may be slightly difficult...";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "to destroy bigger objects.";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "So be smart.";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "Try to grow bigger...";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "by eating smaller objects";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "and then unleash...";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "your fury over the whole city";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "BY CONSUMING IT ALL!";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "Okay... Listen...";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "I don't have anymore time...";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "to speak with you...";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "but good luck...";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "You're going to need it :)";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "Oh...";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "Also...";
        yield return new WaitForSeconds(1);
        antivirus1.GetComponent<Image>().enabled = true;
        antivirus2.GetComponent<Image>().enabled = true;
        antivirus1Text.GetComponent<Text>().enabled = true;
        antivirus2Text.GetComponent<Text>().enabled = true;
        textBox.GetComponent<Text>().text = "Look out for the Anti-Virus guards";
        yield return new WaitForSeconds(2);
       
        textBox.GetComponent<Text>().text = "They can be rather-";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "Uh...";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "ANNOYING.";
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "3.";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "2.";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "1.";
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(3);

    }
}