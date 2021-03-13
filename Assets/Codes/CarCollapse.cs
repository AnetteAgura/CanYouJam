using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollapse : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    IEnumerator OnCollisionEnter2D(Collision2D col)
    {
        if (StaticScore.score >= 50)
        {
            if (col.gameObject.tag == "Player")
            {
                anim.SetTrigger("Collapse");

                GetComponent<BoxCollider2D>().enabled = false;

                StaticScore.score += 15;

                Debug.Log(StaticScore.score);

                yield return new WaitForSeconds(1);

                Destroy(gameObject);
                Debug.Log("Trigger!");
            }
        }
    }
}
