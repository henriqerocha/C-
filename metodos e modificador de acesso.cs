using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{
    metodos somar;

    void Start()
    {
        int result1;
        int result2;
        somar = new metodos();
        result1 = somar.soma(5, 25);
        result2 = somar.soma(30, 10);

        print(result1);
        print(result2);

    }

    void Update()
    {

    }
}

class metodos
{
    //public = modificador de acesso
    //métodos void não retornam nada
    //int = outro método para retornar um inteiro, também poderia ser outros, como float...
    public int soma(int num1, int num2)
    {

        int resultado = num1 + num2;

        return resultado;
    }
}