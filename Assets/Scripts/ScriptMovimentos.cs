using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* [Jogo Arrow]
 * Marcos Felix
 * 06-06-2018
 */

/*
1 - Limpar código
2 - Tempo --> Bateria
3 - Gerador de inimigo (Dois lados)
4 - Botão de ação lado direito

*/

    

public class ScriptMovimentos : MonoBehaviour {

    [SerializeField]
    private AudioClip efeitosound,explosao;
    AudioSource audioSource;

    Vector3 posicao;
    [SerializeField]
    private GameObject efeito;
    [SerializeField]
    private float velociade = 0.1f;
    [SerializeField]
    private GameObject bamba,Panelgameover;

    void Start()
    {
    posicao = transform.position; 
    audioSource = GetComponent<AudioSource>();

    }
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.LeftArrow) &&  transform.position == posicao)
            {  
            if (ScripotPontos.pontosesquerda >0){
            ScripotPontos.pontosesquerda -= 1;
            posicao += Vector3.left * 1;
             }
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position == posicao)
        {    
            if (ScripotPontos.pontosdireita>0){ 
            ScripotPontos.pontosdireita -= 1;
            posicao += Vector3.right * 1;
            }
        }
        if (Input.GetKey(KeyCode.UpArrow) && transform.position == posicao) 
        {   
            if (ScripotPontos.pontoscima >0){
            ScripotPontos.pontoscima -= 1;
            posicao += Vector3.up * 1; 
            }
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position == posicao)
        {   
            if (ScripotPontos.pontosbaixo >0){
            posicao += Vector3.down * 1;
            ScripotPontos.pontosbaixo -=1;
                 
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, posicao, velociade); 
    }
    void Update()
        {
            if (ScripotPontos.pontosbaixo == 0 && ScripotPontos.pontoscima == 0 && ScripotPontos.pontosesquerda == 0
            && ScripotPontos.pontosdireita == 0)
        {
            Panelgameover.SetActive(true);
            Time.timeScale = 0.1f;
        }
        if (ScriptTempo.contagem ==0)
        {
            Panelgameover.SetActive(true);
            Time.timeScale = 0.1f;
        }
    }
    void OnTriggerEnter2D(Collider2D Obj)
    {
        if (Obj.gameObject.tag=="setabaixo")
        {
            ScripotPontos.pontosbaixo +=10;
            Destroy(Obj.gameObject);
            Instantiate(efeito,transform.position,Quaternion.identity);
            audioSource.PlayOneShot(efeitosound);
        }   
        if (Obj.gameObject.tag=="setacima")
        {
            ScripotPontos.pontoscima +=10;
            Destroy(Obj.gameObject);
            Instantiate(efeito,transform.position,Quaternion.identity);
            audioSource.PlayOneShot(efeitosound);
        }   
        if (Obj.gameObject.tag=="setadireita")
        {
            ScripotPontos.pontosdireita +=10;
            Destroy(Obj.gameObject);
            Instantiate(efeito,transform.position,Quaternion.identity);
            audioSource.PlayOneShot(efeitosound);
        }   
        if (Obj.gameObject.tag=="setaesquerda")
        {
            ScripotPontos.pontosesquerda +=10;
            Destroy(Obj.gameObject);
            Instantiate(efeito,transform.position,Quaternion.identity);
            audioSource.PlayOneShot(efeitosound);
        }   
        if (Obj.gameObject.tag=="tempo")
        {
            ScriptTempo.contagem = 100f;
            Destroy(Obj.gameObject);
            Instantiate(efeito,transform.position,Quaternion.identity);
            audioSource.PlayOneShot(efeitosound);
        }  
       
        if (Obj.gameObject.tag=="bomba")
        {
            ScripotPontos.pontosbaixo -=10;
            if (ScripotPontos.pontosbaixo < 0)
        {
            ScripotPontos.pontosbaixo = 0;
        }
            Destroy(Obj.gameObject);
            Instantiate(bamba,transform.position,Quaternion.identity);
            audioSource.PlayOneShot(explosao);
            Panelgameover.SetActive(true);
            Time.timeScale = 0.1f;
        } 

    }

    public void esquerda(){
        if (ScripotPontos.pontosesquerda >0)
         {
            ScripotPontos.pontosesquerda -= 1;
            if (transform.position == posicao)
           {
            posicao += Vector3.left * 1;
            }
        }
    }
    public void direita(){
        if (ScripotPontos.pontosdireita >0)
        {
            ScripotPontos.pontosdireita -= 1;
            if (transform.position == posicao)
            {
            posicao += Vector3.right * 1;
            }
        }
    }
    public void paracima(){
        if (ScripotPontos.pontoscima >0)
        {
            ScripotPontos.pontoscima -= 1;
            if (transform.position == posicao)
            {
            posicao += Vector3.up * 1;
            }
        }
    }
    public void parabaixo(){
        if (ScripotPontos.pontosbaixo >0)
        {
            ScripotPontos.pontosbaixo -= 1;
            if (transform.position == posicao)
            {
            posicao += Vector3.down * 1;
            }
        }
    }
}
