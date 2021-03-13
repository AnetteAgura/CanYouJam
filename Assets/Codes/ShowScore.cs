using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public Text countText;
    public Image youWin;
    public Text youWinText;

    // Start is called before the first frame update
    void Start()
    {
        SetCountText();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        SetCountText();
    }

    void SetCountText()
    {
        countText.text = "Score: " + StaticScore.score.ToString();

        if (StaticScore.score >= 200)
        {
            youWin.enabled = true;
            youWinText.enabled = true;
        }
    }
}
