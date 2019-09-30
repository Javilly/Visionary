using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShpereScript : MonoBehaviour
{
    private bool playerNear;
    public Text canvasQuest;
    public string crazyText = "Ho..hola soy Chapi...estoy escuchando musica a solas...no me siento comodo hablando con personas nuevas...chau";
    public Player player;


    void Update()
    {
        if (playerNear && Input.GetKeyDown(KeyCode.F))
        {
            canvasQuest.text = crazyText;
            player.ChangeMesh(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.name == "Player")
        {
            playerNear = true;
        }
    }

    void OnTriggerExit(Collider c)
    {
        playerNear = false;
        canvasQuest.text = " ";
    }
}