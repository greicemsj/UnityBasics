﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour
{

    int ItensCena = 5;
    int dinheiro = 500;

    // Start is called before the first frame update
    void Start()
    {
        /*while (ItensCena > 0)
        {
            Debug.Log("Item pego");
            ItensCena--;
        }*/

        do
        {

            Debug.Log("Seu dinheiro é " + dinheiro);
            dinheiro += 50;

        } while (dinheiro < 1000);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
