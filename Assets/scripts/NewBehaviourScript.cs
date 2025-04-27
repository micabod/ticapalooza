using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int entradasCampo;
    public int entradasPlatea;
    int totalCampo;
    int totalPlatea;
    int total;
    int predio;
    // Start is called before the first frame update
    void Start()
    {
        if (entradasCampo<0 || entradasCampo>20400 || entradasPlatea<0 || entradasPlatea>16200){
            Debug.Log("Error");
            return;
        }
        totalCampo = 1200 * entradasCampo;
        totalPlatea = 2000 * entradasPlatea;
        total = totalCampo + totalPlatea;
        Debug.Log("La recaudación de las entradas de campo es de"+totalCampo);
        Debug.Log("La recaudacion de las entradas de platea es de"+totalPlatea);
        Debug.Log("La recaudacion total es de"+ total);
        predio= 20400 + 16200;
        int cantVendidas= entradasCampo + entradasPlatea;
        int vacante = predio-entradasCampo-entradasPlatea;
        if(cantVendidas==predio){
            Debug.Log("Sold Out");
        }
        else{
             Debug.Log("La cantidad restante del predio es de"+ vacante);

        }
        if (entradasCampo>10200|| entradasPlatea>8100){
            Debug.Log("El festival fue un exito");
        }
        else{
            Debug.Log("debemos mejorar la convocatoria");
        }
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
