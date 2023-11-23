using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{
    
    void Start()
    {
        //Obrigatoriamente tem que colocar List com a primeira letra maiúscula
       List<int> testeLista = new List<int> ();

        //Obrigatoriamente tem que colocar .Add com a primeira letra maiúscula
       testeLista.Add(100);
       testeLista.Add(200);
       testeLista.Add(300);
       testeLista.Add(400);

       //Para remover algum item da lista basta usar .Remove (VALOR)

       testeLista.Remove(200);

       print(testeLista[1]);

       //Para saber o índice do valor, basta colocar print(testeLista.IndexOf(Valor));
        
        print(testeLista.IndexOf(400));
        
    }

    void Update()
    {
        
    }
}
