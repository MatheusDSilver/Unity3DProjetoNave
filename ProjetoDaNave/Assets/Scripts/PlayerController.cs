using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;


    public int forcaEmX;
    public int forcaEmZ = 50;
    public int velocidadeMaximaZ = 100;

    public GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        forcaEmX = 4500;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Mover no eixo Z - Para frente


        if (rb.velocity.z < velocidadeMaximaZ)
        {
            rb.AddForce(0, 0, forcaEmZ * Time.fixedDeltaTime);
        }
        Debug.Log("Velocidade da Nave - " + rb.velocity.z);

        //Mover no eixo X Direita
        if(Input.GetKey("d")) {
            rb.AddForce(forcaEmX * Time.fixedDeltaTime, 0, 0);
        }
        //Mover no eixo X Esquerda
        if(Input.GetKey("a"))
        {
            rb.AddForce(-forcaEmX * Time.fixedDeltaTime, 0, 0);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
      if(collision.collider.CompareTag("Enemy") || collision.collider.CompareTag("Wall"))
        {
            gameController.GameOver();
        }
    }
}
