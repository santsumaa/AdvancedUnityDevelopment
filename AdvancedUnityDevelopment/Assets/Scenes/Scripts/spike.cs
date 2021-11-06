using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike : MonoBehaviour
{
    public class PlayerDie : MonoBehaviour
    {

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "spike")
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
