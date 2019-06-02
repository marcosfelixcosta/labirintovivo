using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/* [Jogo Arrow]
 * Marcos Felix
 * 06-06-2018
 */

public class ScriptTempo : MonoBehaviour {


    public Text tempo;
    [SerializeField]
    private Image gauge;
	
    [SerializeField]
    public static float contagem = 100f;

	void Start () 
    {
        InvokeRepeating("Contagem" ,0f, 0.1f);	
	}
   
    void Contagem()
    {
        if (contagem > 0.0f)
        {
        contagem -= 0.1f;
        tempo.text = contagem.ToString("0");
        gauge.fillAmount = contagem / 100;

        }
        else
        {
        tempo.text = "0";
        contagem = 0;
        CancelInvoke(); 
        }
      
    }
    public void Jogarnovamente()
    {
        InvokeRepeating("Contagem" ,0f, 0.1f); 
        Time.timeScale = 1;
        SceneManager.LoadScene("Principal");
        ScripotPontos.pontoscima = 10;
        ScripotPontos.pontosbaixo = 10;
        ScripotPontos.pontosdireita = 10;
        ScripotPontos.pontosesquerda = 10;
        ScriptTempo.contagem = 100f;
    }
    public void Sair()
    {
        Application.Quit();
    }
}
