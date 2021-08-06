using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    /* Statistiche
    -proiettili tot
    -firerate
    -reloadtime
    -firerange
    -danno
    */

    protected virtual void FixedUpdate()
    {
        //Ruota l'arma
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        //Spara un proiettile quando premi m1
    }
    
}
