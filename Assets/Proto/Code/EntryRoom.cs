using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryRoom : MonoBehaviour
{
    [SerializeField]public Transform PlayerPos;
    [SerializeField] public Transform TpPos;
    private void Awake()
    {
        PlayerPos = TpPos;
    }
}
