using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandlerCronometro : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI t_tiempo;
    int tiempo;

    private void Awake()
    {
        GameObject obj = GameObject.Find("t_tiempo");
        t_tiempo = obj.GetComponent<TextMeshProUGUI>();
    }

    // Start is called before the first frame update
    void Start()
    {
        tiempo = 30;
        StopAllCoroutines(); //recomendacion
        StartCoroutine("controlTiempo");
    }

    // Update is called once per frame
    void Update()
    {
        if(tiempo == 0)
        {
            SceneManager.LoadScene("gameOVer");
        }
    }

    IEnumerator controlTiempo()
    {
        while (tiempo >= 0)
        {
            t_tiempo.text = tiempo.ToString();
            tiempo--;
            yield return new WaitForSeconds(1f);
        }
    }
}
