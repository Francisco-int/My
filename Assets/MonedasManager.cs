using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonedasManager : MonoBehaviour
{
    [SerializeField]    Text monedaTexto;

    int contador;


    void MonedaTexto(int cantidad)
    {
        contador++;
        monedaTexto.text = "Monedas: " + contador;
    }
 

    private void OnEnable()
    {
        Delegante.miMetodo += MonedaTexto;
    }

    private void OnDisable()
    {
        Delegante.miMetodo -= MonedaTexto;
    }


}
