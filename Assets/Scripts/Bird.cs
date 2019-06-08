using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{

    public float Impulso;
    public GameObject CanvasPonto;
    public AudioClip[] SomClips;
    public GameObject Fx;

    private bool Impulsionar;
    private Rigidbody2D rb;
    private AudioSource Som;

    // Use this for initialization
	void Start ()
    {
        // StartCoroutine(Contar);
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
        Som = GetComponent<AudioSource>();
        Som.clip = SomClips[0];
        Principal.Jogando = true;
    }
	
	// Update is called once per frame (CPU)
	void Update ()
    {		
        // Input Fire1 (ctrl esquerdo, clique do mouse e toque na tela)
        if(Input.GetButtonDown("Fire1") && Principal.Jogando)
        {
            if (rb.gravityScale == 0)
            {
                rb.gravityScale = 1;
                Principal.Velocidade = 4f;
            }
            Impulsionar = true;
            Som.Play();
        }
    }

    // GPU (Gráfico e Física)
    void FixedUpdate()
    {        
        // Impulsionar o pássaro
        if(Impulsionar)
        {
            //if(rb.gravityScale == 0)
            //{
            //    rb.gravityScale = 1;
            //    Principal.Velocidade = 4f;
            //}
            rb.velocity = new Vector2(0f, 0f);
            rb.AddForce(Vector2.up * Impulso);
            Impulsionar = false;
        }

    }

    void OnTriggerExit2D(Collider2D c)
    {
        Placar.Pontos++;
        CanvasPonto.GetComponent<AudioSource>().Play();
        /*
        if(c.collider.name == "Ancora-Cano-Verde" ||
           c.collider.name == "Ancora-Cano-Vermelho") {
        }
        */
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        StartCoroutine(EncerrarJogo());
    }

    IEnumerator EncerrarJogo()
    {
        GetComponent<SpriteRenderer>().enabled = false;

        GameObject explosion = Instantiate(Fx, transform.position, transform.rotation);

        Destroy(explosion, 0.5f);

        Principal.Jogando = false;
        Principal.Velocidade = 0f;
        rb.gravityScale = 0;
        Som.clip = SomClips[1];
        Som.Play();
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("StartScene");
    }

    /*
    int temp;
    IEnumerator Contar()
    {
        print(temp);
        yield return new WaitForSeconds(5.0f);
        temp++;       
        StartCoroutine(Contar());
    } 
    */

}
