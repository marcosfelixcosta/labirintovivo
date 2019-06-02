using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* [Jogo Arrow]
 * Marcos Felix
 * 06-06-2018
 */

public class ScripotPontos : MonoBehaviour {

    public Text textoPontoscima;
    public Text textoPontosdireita;
    public Text textoPontosesquerda;
    public Text textoPontobaixo;

    public  static int pontoscima=10,pontosbaixo =10, pontosdireita =10, pontosesquerda =10;
	
	void Update () {
    textoPontobaixo.text = "" + pontosbaixo;
    textoPontoscima.text = "" + pontoscima;
    textoPontosdireita.text = "" + pontosdireita;
    textoPontosesquerda.text = "" + pontosesquerda;	
	}
}
