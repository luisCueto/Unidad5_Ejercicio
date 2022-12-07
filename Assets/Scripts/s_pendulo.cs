using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_pendulo : MonoBehaviour
{
    [SerializeField]
    float angulo;
    [SerializeField]
    float angulo_acumulado;
    [SerializeField]
    bool cambiaSentido;
    [SerializeField]
    float tiempo_transcurrido;
    // Start is called before the first frame update
    void Start()
    {
        cambiaSentido = false;
        angulo = -1;
        angulo_acumulado = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //if (tiempo_transcurrido >= 0.01)
        //{
            transform.Rotate(new Vector3(0, 0, angulo));
            angulo_acumulado += angulo;

            angulo = cambiaSentido ? .1f : -.1f;

            if (angulo_acumulado >= 40)
            {
                cambiaSentido = false;
                angulo = -.1f;
            }
            else
            {
                if(angulo_acumulado <= -40)
                {
                    cambiaSentido = true;
                    angulo = .1f;
                }
            }

            //tiempo_transcurrido = 0;
        //}
        //tiempo_transcurrido = 0;
        
        
    }
}
