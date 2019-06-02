using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawTop : MonoBehaviour {
    
    [SerializeField]
    private Transform PrefabBomba;
    private float tempoSpaw=4f;

	void Start () 
    {
        InvokeRepeating("Spaw", tempoSpaw,tempoSpaw);	
	}

	void Spaw() 
    {
        Vector3 SpawPosition = new Vector3(Random.Range(-4.48f, 3.5f),transform.position.y,transform.position.z);
        Instantiate(PrefabBomba, SpawPosition, Quaternion.identity);
        transform.position = SpawPosition;

	}
   
}
