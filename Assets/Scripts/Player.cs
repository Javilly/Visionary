using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Movimiento
    public float lookSpeed = 10;
    private Vector3 curLoc;
    private Vector3 prevLoc;


    //Cambiar Mesh
    Mesh swapMesh;
    GameObject theTarget;


    public void ChangeMesh(GameObject swapObject)
    {
        theTarget = this.gameObject;
        swapMesh = swapObject.GetComponent<MeshFilter>().mesh;
        theTarget.GetComponent<MeshFilter>().mesh = swapMesh;
        print("cambie");
    }


    void Update()
    {
        InputListen();
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(transform.position - prevLoc), Time.fixedDeltaTime * lookSpeed);
    }

    private void InputListen()
    {
        prevLoc = curLoc;
        curLoc = transform.position;

        if (Input.GetKey(KeyCode.A))
            curLoc.x -= 7 * Time.fixedDeltaTime;
        if (Input.GetKey(KeyCode.D))
            curLoc.x += 7 * Time.fixedDeltaTime;
        if (Input.GetKey(KeyCode.W))
            curLoc.z += 7 * Time.fixedDeltaTime;
        if (Input.GetKey(KeyCode.S))
            curLoc.z -= 7 * Time.fixedDeltaTime;

        transform.position = curLoc;

    }
}
