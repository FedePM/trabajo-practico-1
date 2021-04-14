using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    public Text CuentaGoles;
    private int goles = 0;

    public void SumarGol(){
        this.goles++;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CuentaGoles.text = ("Goles: " + goles.ToString());
    }
}
