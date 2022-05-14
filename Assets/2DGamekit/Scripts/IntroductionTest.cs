using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroductionTest : MonoBehaviour

{
    private int nombre;
    public int longueur;

    // Start is called before the first frame update
    void Start()
    {
        Counter(longueur);
    }

    // Update is called once per frame
    void Update()
        
    {
        
    }
    void  Counter(int nbr )
    {
        for (int i = 0; i <nbr  ; i++)
        {
            Debug.Log(nombre);
            nombre++;
        }
    }

}
