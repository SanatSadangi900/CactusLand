using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField]
    private string playerTAG;

    [SerializeField]
    private Portal target;

    [SerializeField]
    private Transform spawnPoint;

    public Transform SpawnPoint { get { return spawnPoint; } }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTAG))
        {
            other.transform.position = target.SpawnPoint.position;
        }
    }
}
