using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public PlayerController player;
    Vector3 posicaoInicial;
    float pontuacao;
    public Text textoPontuacao;
    public float divisorPontuacao = 20;
    public GameObject painelGameOver;
    public GameObject painelWinner;
   

    // Start is called before the first frame update
    void Start()
    {
        posicaoInicial = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        pontuacao = (player.transform.position.z - posicaoInicial.z) / divisorPontuacao;
        textoPontuacao.text = pontuacao.ToString("0");
        
    }

    public void GameOver()
    {
        painelGameOver.SetActive(true);
        
    }

    public void RecarregarLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void VencerJogo()
    {
        painelWinner.SetActive(true);
    }

}
