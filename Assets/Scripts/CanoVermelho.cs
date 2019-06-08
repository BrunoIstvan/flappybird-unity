using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoVermelho : MonoBehaviour {

    //private float Velocidade;
    public float LimiteSuperior;
    public float LimiteInferior;

    private Vector2 posicao;


    // Use this for initialization
    void Start()
    {

        Principal.Start();
        // Captura posição inicial do cano para voltar ele no próximo ciclo
        posicao = transform.position;
        //Velocidade = Principal.Velocidade;

    }

    // Update is called once per frame
    void Update()
    {

        // Mover o cano
        transform.Translate(Vector2.left * Principal.Velocidade * Time.deltaTime);

        // Retorna o cano para a sua posição original
        if (transform.position.x < (posicao.x * -1))
        {
            float altura = Random.Range(LimiteInferior, LimiteSuperior);
            transform.position = new Vector2(posicao.x, altura);

        }

    }

}
