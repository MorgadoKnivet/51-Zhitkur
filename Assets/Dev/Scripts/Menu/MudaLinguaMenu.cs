using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MudaLinguaMenu : MonoBehaviour {

    public Button btnStart;
    public Button btnFechar;
    public Dropdown lingua;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (lingua.value == 1)
        {
            Ingles();
        }else if (lingua.value == 0)
        {
            Portugues();
        }else if (lingua.value == 2)
        {
            Espanhol();
        }
	}

    public void Portugues()
    {
        btnStart.GetComponentInChildren<Text>().text = "Começar Jogo";
        btnFechar.GetComponentInChildren<Text>().text = "Fechar";
    }

    public void Ingles()
    {
        btnStart.GetComponentInChildren<Text>().text = "Start Game";
        btnFechar.GetComponentInChildren<Text>().text = "Exit";
    }

    public void Espanhol()
    {
        btnStart.GetComponentInChildren<Text>().text = "Comenzar Juego";
        btnFechar.GetComponentInChildren<Text>().text = "Cerrar Juego";
    }
}
