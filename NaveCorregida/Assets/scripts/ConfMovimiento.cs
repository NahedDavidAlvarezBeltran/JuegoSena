﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfMovimiento : MonoBehaviour {

    public GameObject ElQueseMueve;
    public GameObject dondeMueve;
    public GameObject salida;
    public float tiempoMovimiento;
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void ActivarElMenu(string Activar)
    {
        switch (Activar)
        {
            case "si":
                gameObject.SetActive(true);
                iTween.MoveTo(ElQueseMueve, dondeMueve.transform.position, tiempoMovimiento);
                break;
            case "no":
                iTween.MoveTo(ElQueseMueve, salida.transform.position, tiempoMovimiento);
                break;
        }
    }
}
