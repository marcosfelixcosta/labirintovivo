using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawLeft : MonoBehaviour {

    [SerializeField]
    private Transform PrefabBomba;
    private float tempoSpaw=8f;

    void Start () 
    {
        InvokeRepeating("SpawLef", tempoSpaw,tempoSpaw);   
    }

    void SpawLef() 
    {
        Vector3 SpawPosition = new Vector3(transform.position.x,Random.Range(3.62f, -4.48f),transform.position.z);
        Instantiate(PrefabBomba, SpawPosition, Quaternion.identity);
        transform.position = SpawPosition;

    }
}
