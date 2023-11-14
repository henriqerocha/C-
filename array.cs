using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{
    void Start()
    {
       int[] array = new int[10];
       for(int i = 0; i <= 9; i++){
        array[i] = i + 1;
        print(i + ":" + array[i]);
       }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
