using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//SOBRECARGA DE MÉTODO = Consegue fazer muitos métodos com o mesmo nome, mudando apenas o tipo(inteiro, float, etc...)
public class exercicio : MonoBehaviour
{

    //############## OBJETOS ##################

    Zumbi nameZumbi;
    Zumbi lifeZumbi;

    void Start()
    {

        nameZumbi = new Zumbi();
        lifeZumbi = new Zumbi();

        string resultName = nameZumbi.nomeZumbi = "Richard";
        int resultVida = lifeZumbi.vidaZumbi = 250;

        print(resultName);
        print(resultVida);


        //################ FIM OBJETOS #################


        //################ QUESTIONÁRIO ################

        //  1 -   Crie variáveis para representar os seguintes itens:Número de vidas, Número de moedas, Nome, Energia.
        int vidas;
        float moedas;
        string nickName;
        float energia;

        //  2 -   Faça uma soma usando os valores inteiros de duas variáveis (valor1 e
        // valor2), coloque o resultado em uma terceira variável (result) e exiba
        // no console seu resultado.

        int valor1 = 10, valor2 = 20;
        int result = valor1 + valor2;

        print(result);

        //   3 -   Crie uma estrutura condicional que exibe a palavra Unity se, e
        // somente se a variável inteira (engine) for maior que 10.

        int engine = 11;

        if (engine > 10)
        {
            print("Unity");
        }

        //   4 -   Crie um laço de qualquer tipo que seja capaz de imprimir no console
        // números de 0 (zero) até 10.

        for (int i = 0; i <= 10; i++)
        {
            print(i);
        }

        //   5 -   Crie um vetor para guardar 5 nomes de vilões, depois imprima no
        // console cada um dos nomes.

        string[] viloes = new string[5];

        viloes[0] = "Ferumbras";
        viloes[1] = "Morgaroth";
        viloes[2] = "Ghazbaran";
        viloes[3] = "Laidy Tenebris";
        viloes[4] = "Orshabaal";

        foreach (string nomeViloes in viloes)
        {
            print(nomeViloes);
        }

        //   6 -   Crie uma lista contendo 10 elementos de qualquer tipo depois 
        // imprima cada elemento no console

        List<int> Number = new List<int>();
        Number.Add(100);
        Number.Add(200);
        Number.Add(400);
        Number.Add(600);
        Number.Add(800);
        Number.Add(700);
        Number.Add(900);
        Number.Add(300);
        Number.Add(500);
        Number.Add(1000);

        //TAMBÉM PODE SER FEITO DESSA FORMA ABAIXO... 
        //for(int i = 0; i < 10; i++)
        // {
        //     print(Number[i]);
        // }    

        foreach (int resulNumber in Number)
        {
            print(resulNumber);
        }
    }

    //   7 -   Crie uma classe que represente um zumbi, todos seus atributos 
    //devem ser públicos.

    class Zumbi
    {

        //   8 -   Crie um objeto da classe zumbi e exiba no console cada atributo 
        //criado
        public string nomeZumbi;
        public int vidaZumbi;
    }

    class Zumbi_Filho : Zumbi
    {
        protected string estiloAtaque;
        protected int danoAtaque;
    }

    void Update()
    {

    }
}
