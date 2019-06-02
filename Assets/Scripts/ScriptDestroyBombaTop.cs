using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDestroyBombaTop : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D bmb)
    {
        if (bmb.gameObject.tag == "bomba")
        {
            Destroy(bmb.gameObject);
            Handheld.Vibrate();
        }
    }
}
