using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScaling : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    private Vector3 scaleChange, scaleChange1;
    private int timer = 0;

    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Awake()
    {
        scaleChange = new Vector3(1f, 1f, 0f);
        scaleChange1 = new Vector3(1.5f, 1.5f, 0f);
    }

     void Update()
    {
        StartCoroutine(Scaling());
    }
    // Update is called once per frame
    IEnumerator Scaling()
    {

        if (StaticScore.score == 20 && timer == 0)
        {
            anim.SetTrigger("Scale");
            Debug.Log("ScaleUp!");
            timer += 1;

            yield return new WaitForSeconds(1);

            player.transform.localScale += scaleChange;
            anim.SetTrigger("Play");
        }

        if (StaticScore.score >= 50 && timer == 1)
        {
            anim.SetTrigger("Scale");
            Debug.Log("ScaleUp!");
            timer += 1;

            yield return new WaitForSeconds(1);

            player.transform.localScale += scaleChange1;
            anim.SetTrigger("Play");
        }

        if (StaticScore.score >= 100 && timer == 2)
        {
            anim.SetTrigger("Scale");
            Debug.Log("ScaleUp!");
            timer += 1;

            yield return new WaitForSeconds(1);

            player.transform.localScale += scaleChange1;
            anim.SetTrigger("Play");
        }

        if (StaticScore.score <= 19 && timer == 1)
        {
            anim.SetTrigger("Scale");
            Debug.Log("ScalingDown!");
            timer -= 1;

            yield return new WaitForSeconds(1);

            player.transform.localScale -= scaleChange;
            anim.SetTrigger("Play");
        }

        if (StaticScore.score <= 49 && timer == 2)
        {
            anim.SetTrigger("Scale");
            Debug.Log("ScalingDown!");
            timer -= 1;

            yield return new WaitForSeconds(1);

            player.transform.localScale -= scaleChange1;
            anim.SetTrigger("Play");
        }

        if (StaticScore.score <= 99 && timer == 3)
        {
            anim.SetTrigger("Scale");
            Debug.Log("ScalingDown!");
            timer -= 1;

            yield return new WaitForSeconds(1);

            player.transform.localScale -= scaleChange1;
            anim.SetTrigger("Play");
        }
    
    }
}
