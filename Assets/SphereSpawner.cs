﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    void Update()
    {
        if (Random.Range(0, 100) < 10)
        {
            Sphere.Clone(transform.position);
        }
    }
}
