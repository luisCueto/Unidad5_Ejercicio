using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_MovPlataformas : MonoBehaviour
{
    [SerializeField]
    List<Transform> puntos;
    [SerializeField]
    int index_punto_destino;

    [SerializeField]
    int punto_destino_p1;
    [SerializeField]
    int punto_destino_p2;
    [SerializeField]
    int punto_destino_p3;

    [SerializeField]
    Transform plataforma1;
    [SerializeField]
    Transform plataforma2;
    [SerializeField]
    Transform plataforma3;
    // Start is called before the first frame update
    void Start()
    {
        punto_destino_p3 = 3;
        punto_destino_p2 = 2;
        punto_destino_p1 = 1;

        index_punto_destino = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,
            puntos[index_punto_destino].position, 0.01f);

        if (
            Vector3.Distance(transform.position,
                puntos[index_punto_destino].position) <= 0.1)
        {
            index_punto_destino = ++index_punto_destino % puntos.Count;
        }
    }
}
