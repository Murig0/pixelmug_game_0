using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    //Questo script è praticamente tutto un placeholder però bo era pe fare

    public SpriteRenderer spriteRenderer;
    public Sprite myNewSprite;


    //se flagtypeorange è true allora è bandiera arancione, altrimenti è blu
    public bool flagTypeOrange;


        void OnTriggerEnter2D(Collider2D col)
    {
        if(flagTypeOrange)
        {
            //lol
        }
        else
        {
            Destroy(this.gameObject);
            spriteRenderer.sprite = myNewSprite;
        }
    }
}
