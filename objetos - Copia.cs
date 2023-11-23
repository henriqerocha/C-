using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{

    //Para criar objetos faça daqui de baixo...
    vocChar Knight;
    vocChar Paladin;
    vocChar Sorcerer;
    vocChar Druid;

    void Start()
    {

        Knight = new vocChar();
        Paladin = new vocChar();
        Sorcerer = new vocChar();
        Druid = new vocChar();

        //********* Até aqui para criar um objeto ********

        

    }

    void Update()
    {

    }
}


class vocChar
{

    //Precisa ter as características...
    public string nomeVoc;
    string stiloVoc;
    int vidaVoc;

    //Precisa ter as ações = Métodos

    void Atacar()
    {

    }
}