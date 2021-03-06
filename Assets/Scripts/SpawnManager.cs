﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            Vector3 PosToSpwan = new Vector3(Random.Range(-9.8f, 9.8f), 5.8f, 0);
            Instantiate(_enemyPrefab, PosToSpwan, Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
    }
}
