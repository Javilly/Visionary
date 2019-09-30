using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeScript : MonoBehaviour
{
    private bool playerNear;
    public Text canvasQuest;
    public string crazyText = "Buenas compañero, o ya debería decir amigo ya que siento que vos y yo nos parecemos mucho, me gusta concoer gente nueva. Tengo amigos por todo el mundo";
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
