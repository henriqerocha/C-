using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{

    void Start()
    {
        Dictionary<string, string> boss = new Dictionary<string, string>();

        boss.Add("Rei do Tank", "Matador de Rimas");
        boss.Add("Rei do Coliseu", "Matador de Rimas dois");
        boss.Add("Rei do Ana Rosa", "Matador de Rimas três");

        foreach (string chave in boss.Keys)
        {
            print(boss[chave]);
        }
    }

    void Update()
    {

    }
}
