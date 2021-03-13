using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (StaticScore.score >= 70)
        {
            if (col.gameObject.tag == "Player")
            {
                GetComponent<BoxCollider2D>().enabled = false;

                StaticScore.score += 20;

                Debug.Log(StaticScore.score);

                Destroy(gameObject);
                Debug.Log("Trigger!");
            }
        }

        if (StaticScore.score <= 69)
        {
            StaticScore.score -= 25;

            Debug.Log(StaticScore.score);

            Debug.Log("Trigger!");

        }
    }
}
