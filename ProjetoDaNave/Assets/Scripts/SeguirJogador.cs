using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirJogador : MonoBehaviour
{
    public PlayerController playerControler;
    Vector3 distanciaCameraJogador = new Vector3(0, 10, -15);
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = playerControler.transform.position + distanciaCameraJogador;
    }
}
