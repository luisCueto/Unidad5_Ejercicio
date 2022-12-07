using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muro : MonoBehaviour
{
    [SerializeField]
    float velocidad;

    [SerializeField]
    List<Transform> puntos;

    [SerializeField]
    int punto_destino_p1;
    [SerializeField]
    int punto_destino_p2;

    [SerializeField]
    Transform Muro1;
    

    // Start is called before the first frame update
    void Start()
    {
        velocidad = 5f;

        punto_destino_p2 = 1;
        punto_destino_p1 = 1;
    }

    // Update is called once per frame
    void Update()
    {


        Muro1.position = Vector3.MoveTowards((Muro1.position), puntos[punto_destino_p1].position, velocidad * Time.deltaTime);

        if (Vector3.Distance(Muro1.position, puntos[punto_destino_p1].position) <= 0.1)
        {
            punto_destino_p1 = ++punto_destino_p1 % puntos.Count;
        }
    }
}

