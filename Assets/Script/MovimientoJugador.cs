using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimientoJugador : MonoBehaviour

   

{
    [SerializeField]
    
    GameObject pantallaFinal;

    public float m_Speed = 200f;
    Rigidbody Player;
    Vector3 direction;
    private object TotalCoin;
    public int Score;
    public Text ScoreText;
    bool PlayerOn = true;


    void Start()
    {
        Player = GetComponent<Rigidbody>();
        Score = 0;
    }



    private void FixedUpdate()
    {

        Player.AddForce(direction, ForceMode.Impulse);

    }



    void Update()
    {
        if (PlayerOn == true)
        {
            direction.x = Input.GetAxis("Horizontal") * Time.deltaTime * m_Speed;
            direction.z = Input.GetAxis("Vertical")  * Time.deltaTime * m_Speed;
        
            
        }

        if (Score == 8)
        {
            {

                pantallaFinal.SetActive(true);
                PlayerOn = false;
            
             }
            
        }


    }
       
        void OnTriggerEnter (Collider other)
    
    {
    
        if (other.tag == "Coin")
        {

         other.gameObject.SetActive(false);
         Score++;
         ScoreText.text = "Score = " + Score;

        }

    }
    
}

