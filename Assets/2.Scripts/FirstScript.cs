using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // Operadores Logicos 
    //    &&  And
    //    ||  Or
    //    !   Not

    int condicion = 1; 


    private void Start()
    {
        switch (condicion) 
        {
            case 1:
                Debug.Log("Ataque Basico");
                break;
            case 2:
                Debug.Log("Ataque Fuerte");
                break; 
            case 3:
                Debug.Log("Ataque Magico");
                break;  

        }


    }



}
