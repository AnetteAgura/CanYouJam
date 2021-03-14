using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseCollapse : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    IEnumerator OnCollisionEnter2D(Collision2D col)
    {
        if (StaticScore.score >= 100)
        {
            if (col.gameObject.tag == "Player")
            {
                anim.SetTrigger("Collapse");

                GetComponent<BoxCollider2D>().enabled = false;

                Debug.Log(StaticScore.score);

                yield return new WaitForSeconds(1);

                StaticScore.score += 25;

                Destroy(gameObject);
                Debug.Log("Trigger!");
            }
        }
    }
}
