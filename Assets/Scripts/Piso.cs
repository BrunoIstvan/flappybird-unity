using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piso : MonoBehaviour {
    

// Update is called once per frame
	void Update () {


        // Mover o piso
        transform.Translate(Vector2.left * Principal.Velocidade * Time.deltaTime);

        // Reposiciona o piso para um novo ciclo

        if(transform.position.x < Principal.LimiteX)
        {
            transform.position = new Vector2(Principal.Retorno, transform.position.y);
        }

	}



    // Use this for initialization
    void Start() {

        Principal.Start();

    }

}
