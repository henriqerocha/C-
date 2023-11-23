using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{

    enum posicoes { parado, correndo, atacando }
    void Start()
    {

        posicoes posicao1 = posicoes.parado;
        posicoes posicao2 = posicoes.atacando;
        posicoes posicao3 = posicoes.correndo;

        int pos1 = (int)posicao1;
        print(pos1);
    }

    void Update()
    {

    }
}
