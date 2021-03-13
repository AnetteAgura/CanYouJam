using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScaling : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    private Vector3 scaleChange, scaleChange1;
    private int timer = 0;

    // Start is called before the first frame update
    void Awake()
    {
        scaleChange = new Vector3(1f, 1f, 0f);
        scaleChange1 = new Vector3(1.5f, 1.5f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(StaticScore.score == 20 && timer == 0) 
        {
            Debug.Log("ScaleUp!");
            player.transform.localScale += scaleChange;
            timer += 1;
        }

        if (StaticScore.score >= 50 && timer == 1)
        {
            player.transform.localScale += scaleChange1;
            timer += 1;
        }

        if (StaticScore.score >= 100 && timer == 2)
        {
            player.transform.localScale += scaleChange1;
            timer += 1;
        }
    }
}
