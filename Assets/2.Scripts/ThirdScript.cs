using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdScript : MonoBehaviour
{


    void Start()
    {
        //StartCoroutine(Coroutine(3.5f)); 
        Invoke("Disparar", 3); 
    }

    private void Update()
    {



    }

    void Disparar()
    {
        Debug.Log("Disparo"); 
    }


    //IEnumerator Coroutine (float time)
    //{
    //    Debug.Log("Hola");

    //    yield return new WaitForSeconds(time);

    //    Debug.Log("Buenos Dias");

    //    yield return new WaitForSeconds(time);

    //    Debug.Log("Hasta Luego");


    //    StartCoroutine(Coroutine(3));

    //}
}
