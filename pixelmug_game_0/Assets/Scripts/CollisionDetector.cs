using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ICollidable obj = collision.gameObject.GetComponent<ICollidable>();
        if (obj != null)
        {
            obj.EnterCollidable();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        ICollidable obj = collision.gameObject.GetComponent<ICollidable>();
        if (obj != null)
        {
            obj.ExitCollidable();
        }
    }

}
