using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "EnemyData", menuName = "My Game/EnemyData")]
public class EnemyData : ScriptableObject
{
    public string enemyName;
    public int mo_health = 3;
    public float speed = 0.5f;
    public int damage = 1;
    public GameObject enemyModel;
}
