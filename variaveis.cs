using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis : MonoBehaviour
{
 
    int num1 = 10;
    int num2 = 2;
    int num3 = 5;
    bool resultado;

    void Start()
    {
        resultado = num1 > num2;
        print(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
