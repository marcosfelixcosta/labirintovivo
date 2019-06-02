using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* [Jogo Arrow]
 * Marcos Felix
 * 06-06-2018
 */

public class ScriptAjusteTela : MonoBehaviour {

   //SpriteRenderer Grafico;
    [SerializeField]
    private float OrtoSize = 5;
    [SerializeField]
    private float Aspect=1.75f;
   // float larguraTela;
    // Use this for initialization
    void Start () {

      // Grafico = GetComponent<SpriteRenderer>();
        AjustaTelaOpcao2();

    }



//   void AjustaTelaOpcao1(){
//
//        float larguraImagem = Grafico.sprite.bounds.size.x;
//        float alturaImagem = Grafico.sprite.bounds.size.y;
//
//        float alturaTela = Camera.main.orthographicSize * 2f;
//        larguraTela = alturaTela / Screen.height * Screen.width;
//
//        Vector2 novaEscala = transform.localScale;
//        novaEscala.x = larguraTela / larguraImagem;
//        novaEscala.y = alturaTela / alturaImagem;   
//        this.transform.localScale = novaEscala;

//}

    void AjustaTelaOpcao2(){
        Camera.main.projectionMatrix = Matrix4x4.Ortho(-OrtoSize * Aspect, OrtoSize 
         * Aspect, -OrtoSize, OrtoSize, Camera.main.nearClipPlane, Camera.main.farClipPlane);
      
    }

















}
