using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCollapse : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    IEnumerator OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            anim.SetTrigger("Collapse");

            GetComponent<BoxCollider2D>().enabled = false;

            yield return new WaitForSeconds(1);

            Destroy(gameObject);
            Debug.Log("Trigger!");
        }
    }
}
