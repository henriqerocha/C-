using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//SOBRECARGA DE MÉTODO = Consegue fazer muitos métodos com o mesmo nome, mudando apenas o tipo(inteiro, float, etc...)
public class array : MonoBehaviour
{

    calculadora soma;

    void Start()
    {
        soma = new calculadora();
        int result = soma.calcula(10, 20);
        float result2 = soma.calcula(5.2f, 5.1f);

        print(result);
        print(result2);
    }

    void Update()
    {

    }
}

class calculadora
{
    public int calcula(int num1, int num2)
    {
        return num1 + num2;
    }

    public float calcula(float num1, float num2)
    {
        return num1 + num2;
    }

}