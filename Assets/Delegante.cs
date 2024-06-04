using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegante : MonoBehaviour
{
  public static event Action<int> miMetodo;


    private void OnCollisionEnter(Collision collision)
    {
        miMetodo?.Invoke(1);
        Destroy(this.gameObject);
    }
}
