using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Placar : MonoBehaviour {

    public Text txtPlacar;

    public static int Pontos;

	// Use this for initialization
	void Start () {

        if(Principal.Jogando) { 
            Pontos = 0;
        }

    }
	
	// Update is called once per frame
	void Update () {

        txtPlacar.text = Pontos.ToString();

    }
}
