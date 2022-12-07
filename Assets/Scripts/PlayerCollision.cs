using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{

    [SerializeField] GameObject player;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float spawnValue;

    [SerializeField]
    TextMeshProUGUI texto;
    public float contadorVida;

    public int vidas = 5;
    
    

    // Start is called before the first frame update
    void Start()
    {
        texto.text = vidas.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (vidas ==0)
        {
            SceneManager.LoadScene("GameOVer");
        }
    }

    

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Mano Entra en colision con: " + collision.gameObject.name);
       if (collision.gameObject.name == "DetectorCaida")
        {
            transform.position = spawnPoint.position;
            vidas -= 1;
            texto.text = vidas.ToString();
        }
       if(collision.gameObject.tag == "meta")
        {
            SceneManager.LoadScene("Ganador");
        }
    }
}
