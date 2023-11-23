using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{
    vocChar Knight;
    vocChar Paladin;
    vocChar Sorcerer;
    vocChar Druid;

    filha fi;

    void Start()
    {

        Knight = new vocChar();
        Paladin = new vocChar();
        Sorcerer = new vocChar();
        Druid = new vocChar();
        fi = new filha();

        //Knight.nomeVoc = "guerreiro";
        Knight.stiloVoc = "ataque Corpo a corpo";
        Knight.vidaVoc = 400;

        //Paladin.nomeVoc = "Atirador";
        Paladin.stiloVoc = "Ataque a distância";
        Paladin.vidaVoc = 375;

        //Sorcerer.nomeVoc = "Mago de dano";
        Sorcerer.stiloVoc = "Ataque a media distancia";
        Sorcerer.vidaVoc = 350;

        //Druid.nomeVoc = "Mago de cura";
        Druid.stiloVoc = "Ataque a media distancia";
        Druid.vidaVoc = 350;

        fi.testeFilha();

        //print(Knight.nomeVoc);
        print(Knight.stiloVoc);
        print(Knight.vidaVoc);
    }

    void Update()
    {

    }
}


class vocChar : MonoBehaviour
{

    //Precisa ter as características...

    //public - Deixa publico para utilizar em todas as classes
    //private - Pode-se utilizar somente na mesma classe
    //protected - Pode-se utilizar na própria classe e classes filhas
    protected string nomeVoc;
    public string stiloVoc;
    public int vidaVoc;

    //Precisa ter as ações = Métodos

    void Atacar()
    {

    }
}

class filha : vocChar
{
    public void testeFilha()
    {
        print(nomeVoc = "Sorcruid");

    }
}