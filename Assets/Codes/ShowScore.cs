using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public Text countText;
    public Image youWin;
    public Text youWinText;
    public Button replay;
    public Button mainMenu;
    public Text replayText;
    public Text mainMenuText;

    // Start is called before the first frame update
    void Start()
    {
        SetCountText();
        youWin.enabled = false;
        youWinText.enabled = false;
        replay.enabled = false;
        mainMenu.enabled = false;
        mainMenuText.enabled = false;
        replayText.enabled = false;
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
            replay.enabled = true;
            mainMenu.enabled = true;
            mainMenuText.enabled = true;
            replayText.enabled = true;
        }

        if (StaticScore.score == 0)
        {
            youWin.enabled = false;
            youWinText.enabled = false;
            replay.enabled = false;
            mainMenu.enabled = false;
            mainMenuText.enabled = false;
            replayText.enabled = false;
        }
    }
}
