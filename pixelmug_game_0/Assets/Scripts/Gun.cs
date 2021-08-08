using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    //TODO: non puo essere fatto con una classe che deriva da MonoBehaviour, possiamo fare degli scriptableObj che poi verrano letti dalla singola arma posseduta
    /*  
    Statistiche
    -proiettili tot
    -firerate
    -reloadtime
    -firerange
    -danno
    */

    public Camera mainCamera;

    

    private void FixedUpdate()
    {

        Vector3 mousePos = Input.mousePosition;
        Vector3 screenPoint = mainCamera.WorldToScreenPoint(transform.position);

        if (mousePos.x < screenPoint.x)
        {
            return;
        }

        //Ruota l'arma
        var dir = mousePos - screenPoint;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        
        //Spara un proiettile quando premi m1
    }
    
}
