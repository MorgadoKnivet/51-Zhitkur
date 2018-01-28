using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnsMenu : MonoBehaviour {

    public Dropdown selectLingua;


    // Use this for initialization
    void Start () {


    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BtnStart()
    {
        SceneManager.LoadScene("Instructions");

        if (selectLingua.value == 0)
        {
            Linguagem.linguagem = 0;
        }
        else if (selectLingua.value == 1)
        {
            Linguagem.linguagem = 1;
        }
        else if (selectLingua.value == 2)
            Linguagem.linguagem = 2;
    }

    public void BtnFechar()
    {
        Application.Quit();
    }
}
