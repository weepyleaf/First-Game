using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{

    public GameObject[] objetos; //grupo de variables del mismo tipo ([])

    public float tMin, tMax;
    public float xMin, xMax;
    public float zMin, zMax;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("GenerarObjeto", Random.Range(tMin, tMax));
    }

    public void GenerarObjeto()
    {
        Invoke("GenerarObjeto", Random.Range(tMin, tMax));

        Vector3 offset = new Vector3(Random.Range(xMin, xMax), 2, Random.Range(zMin, zMax));

        int posArray = Random.Range(0, objetos.Length); //genera los objetos

        Instantiate(objetos[posArray], transform.position + offset, objetos[posArray].transform.rotation);

    }


}
