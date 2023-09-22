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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
