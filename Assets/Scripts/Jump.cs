using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class Jump : MonoBehaviour
{
    public float fuerzaSalto;
    Rigidbody2D rb;
    float velocidadRotacion;
    GameManager gm;

    private bool empezar;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        rb = GetComponent<Rigidbody2D>();
        velocidadRotacion = -3.0f;
        StartCoroutine(Esperar());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && gm.Jugando.Equals(0) && empezar) { 
            gm.Jugando = 1;
            rb.WakeUp();
        }

        if (gm.Jugando.Equals(1))
        {
            //texto.text = puntos.ToString();
            gameObject.GetComponent<Animator>().SetBool("Normal", true);

            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(0.0f, fuerzaSalto), ForceMode2D.Impulse);
            }

            int dire = rb.velocity.y >= 0 ? -2 : 1;
            transform.rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, rb.velocity.magnitude * velocidadRotacion * dire));

        }
        else
        {
            rb.Sleep();
            //rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }

    }
    IEnumerator Esperar()
    {
        yield return new WaitForSeconds(0.5f);
        empezar = true;
    }

}
