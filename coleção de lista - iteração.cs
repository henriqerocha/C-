using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{
    
    void Start()
    {
        //Obrigatoriamente tem que colocar List com a primeira letra maiúscula
       List<int> testeLista = new List<int> ();

       for(int i = 0; i <= 9; i++){
        testeLista.Add(i);
       }

       foreach(int valores in testeLista){
        print(valores);
       }
        
    }

    void Update()
    {
        
    }
}
