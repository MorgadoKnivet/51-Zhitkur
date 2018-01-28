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
        SceneManager.LoadScene("_MainGame");

        if(selectLingua.value==0)
        {
            Linguagem.linguagem = true;
        }
        else
        {
            Linguagem.linguagem = false;
        }
    }

    public void BtnFechar()
    {
        Application.Quit();
    }
}
