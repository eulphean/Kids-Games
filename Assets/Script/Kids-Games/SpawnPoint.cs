﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField]
    public float radius;
    public List<TargetPoint> initialTargets; 

    void OnDrawGizmos() {
        Gizmos.color = Color.green; 
        Gizmos.DrawWireSphere(gameObject.transform.localPosition, radius);
    }
}
