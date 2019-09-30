using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarMesh : MonoBehaviour
{
    public GameObject initialObject;
    public GameObject swapObject;

    Mesh initialMesh;
    Mesh swapMesh;

    GameObject theTarget;

    // Use this for initialization
    void Start()
    {

        theTarget = initialObject;

        initialMesh = initialObject.GetComponent<MeshFilter>().mesh;
        swapMesh = swapObject.GetComponent<MeshFilter>().mesh;

        theTarget.GetComponent<MeshFilter>().mesh = swapMesh;
    }
}
