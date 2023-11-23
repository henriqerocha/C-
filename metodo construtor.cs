using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//Método contrutor: Serve para dar valor a um objeto antes mesmo de ser declarado.
//O valor do objeto pode ser alterado posteriormente.
public class array : MonoBehaviour
{

    metodos obj;

    void Start()
    {
        obj = new metodos();

        print(obj.valor1);
        print(obj.valor2);
    }

    void Update()
    {

    }
}

class metodos
{
    public int valor1;
    public string valor2;

    public metodos()
    {
        valor1 = 14;
        valor2 = "Dia aniversário";

    }
}