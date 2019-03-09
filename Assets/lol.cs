using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lol : MonoBehaviour
{
    SpriteRenderer xd;
    bool yolo;
    int xdxd;
    // Start is called before the first frame update
    void Start()
    {
        xd = this.gameObject.GetComponent<SpriteRenderer>();
        yolo = false;
        xdxd = 0;
        xd.flipY = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (yolo == false)
        {
            StartCoroutine(ekisde());
            xdxd++;
        }
        else if (yolo == true)
        {
            StartCoroutine(ekisdo());
            xdxd++;
        }

        if (xdxd == 3)
        {
            xd.flipY = false;
            StartCoroutine(ekisda());
        }
        
            

    }

    IEnumerator ekisde()
    {
        yield return new WaitForSeconds(1);
        xd.flipX = true;
        yolo = true;

    }
    IEnumerator ekisdo()
    {
        yield return new WaitForSeconds(1);
        xd.flipX = false;
        yolo = false;

    }
    IEnumerator ekisda()
    {
        yield return new WaitForSeconds(1);
        xd.flipY = true;
        xdxd = 0;
        

    }

}
