using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Iniciar : MonoBehaviour {

    private Button btnIniciar;

	// Use this for initialization
	void Start () {

        btnIniciar = GetComponent<Button>();

        btnIniciar.onClick.AddListener(Entrar);

    }

    void Entrar()
    {
        Placar.Pontos = 0;
        SceneManager.LoadScene("GameScene");
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
