using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEn : MonoBehaviour
{
    [SerializeField] NivelConfig config;

    void Start()
    {
        int cant = config.catEnemigos;
        for (int i = 0; i < cant; i++)
        {
            Vector3 pos = config.posEnemigos[i];

            int ran = Random.Range(0, config.enemigos.Count);
            Instantiate(config.enemigos[ran], pos, config.enemigos[ran].transform.rotation);          
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
