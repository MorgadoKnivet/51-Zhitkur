using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Instructions : MonoBehaviour {

    public Text titulo;
    public Text texto;
    public Text legendaCientista;
    public Text legendaMonstro;
    public Text legendaSoldado;


    // Use this for initialization
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if (Linguagem.linguagem == 0)
        {
            Portugues();
        }
        else if (Linguagem.linguagem == 1)
        {
            Ingles();
        }
        else if (Linguagem.linguagem == 2)
            Espanhol();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("_MainGame");
    }

    public void Portugues()
    {
        titulo.text = "Instruções";
        texto.text = "Clique nas portas para abrí-las ou fechá-las e permitir que o soldado resgate os cientistas presos pelo complexo, ao mesmo tempo mantenha a criatura infectada longe dos sobreviventes.";
        legendaCientista.text = "Cientistas";
        legendaSoldado.text = "Soldado";
        legendaMonstro.text = "Criatura";
    }

    public void Ingles()
    {
        titulo.text = "Instructions";
        texto.text = "Click on the doors to open or close them and allow the soldier to rescue the scientis trapped in the complex, at the same time keep the infected creature away from the survivors.";
        legendaCientista.text = "Scientists";
        legendaSoldado.text = "Soldier";
        legendaMonstro.text = "Creature";
    }

    public void Espanhol()
    {
        titulo.text = "Instrucciones";
        texto.text = "Haga clic en las puertas para abrirlas o cerralas y permitir que el soldado rescate a los científicos atrapados en el complejo, al mismo tiempo mantenga la criatura infectada lejos de los sobrevivientes.";
        legendaCientista.text = "Científicos";
        legendaSoldado.text = "Soldado";
        legendaMonstro.text = "Criatura";
    }

}
