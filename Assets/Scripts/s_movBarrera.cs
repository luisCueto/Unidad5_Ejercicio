using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_movBarrera : MonoBehaviour
{
    [SerializeField]
    List<Transform> puntos;

    [SerializeField]
    int index_punto_actual; //índice del punto destino actual

    // Start is called before the first frame update
    void Start()
    {
        index_punto_actual = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, puntos[index_punto_actual].position, 10f);
    }
}
