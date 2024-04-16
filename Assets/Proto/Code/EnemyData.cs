using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "EnemyData", menuName = "My Game/EnemyData")]
public class NewBehaviourScript : ScriptableObject
{
    public string enemyName;
    public int health = 3;
    public float speed = 0.5f;
    public int damage = 1;
    public GameObject enemyModel;
}
