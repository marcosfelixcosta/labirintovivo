using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMovimentoLeft : MonoBehaviour {


	void Update () {
        transform.Translate(-Time.deltaTime,0,0);
       // transform.position = new Vector3(transform.position.x * Time.deltaTime, transform.position.y,transform.position.z);
	}
}
