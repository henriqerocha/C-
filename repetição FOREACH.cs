using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{
    
    void Start()
    {
        string[] vocacoes = new string[4];
        vocacoes[0] = "Knight";
        vocacoes[1] = "Paladin";
        vocacoes[2] = "Sorcerer";
        vocacoes[3] = "Druid";

        foreach(string valor in vocacoes){
            
            print(valor);

            if(valor == vocacoes[1]){
            print("Vocação mais brabra!");

            
        }
        }

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
