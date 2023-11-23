using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Método estático = Não precisa declarar um objeto, pode-se fazer direto no start de o static tiver sido informado antes.
public class array : MonoBehaviour
{



    void Start()
    {
        int equacao = metodos.soma(5, 5);
        print(equacao);
    }

    void Update()
    {

    }
}

class metodos
{
    public static int soma(int val1, int val2)
    {
        int resultado = val1 + val2;

        return resultado;
    }

}