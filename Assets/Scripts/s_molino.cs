using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_molino : MonoBehaviour
{
    [SerializeField]
    float angulo;
    [SerializeField]
    float tiempo_rotacion;
    // Start is called before the first frame update
    void Start()
    {
        angulo = 0;
        tiempo_rotacion = 0.01f;
        StartCoroutine("Molino_Movimiento");
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    IEnumerator Molino_Movimiento()
            {
                while (true)
                {
                    yield return new WaitForSeconds(tiempo_rotacion);

                    Quaternion destino = Quaternion.Euler(new Vector3(0, angulo, 0));
                            transform.rotation = destino;
                            angulo++;

                            if (angulo == 360)
                            {
                                angulo = 1;
                            }
                }
            }

}
