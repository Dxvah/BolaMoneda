using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimientoJugador : MonoBehaviour
{
    public float m_Speed = 200f;
    Rigidbody m_Rigidbody;
    int Coin = 0;
    private object TotalCoin;
    int Score;
    public Text ScoreText;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        Score = 0;
    }

    void Update()
    {
        
        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        m_Rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * m_Speed);
        
        if (Score == 8)
        {


            ScoreText.text = "You Win!";

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

