using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Principal : MonoBehaviour {

    public static float Velocidade;
    public static float LimiteX;
    public static float Retorno;

    public static bool Jogando;

    // Use this for initialization
    public static void Start () {
        Velocidade = 0f;
        LimiteX = -10f;
        Retorno = 3f;
    }
	
	// Update is called once per frame
	void Update () {


    }
}
