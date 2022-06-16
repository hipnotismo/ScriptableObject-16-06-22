using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Configuracion")]
public class NivelConfig : ScriptableObject
{
    public int catEnemigos;
    public List<Vector3> posEnemigos;
    public List<GameObject> enemigos;
}
