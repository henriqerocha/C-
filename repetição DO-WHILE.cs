using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{

    //Vai acontecer pelo menos uma vez a ação, mesmo que a condição seja falsa!!!

    int i = 0;
    void Start()
    {
        do{
            print("O número sorteado foi: " + i);
            i++;
        }

       while(i > 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
