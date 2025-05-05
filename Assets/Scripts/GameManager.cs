using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject offenceVehicle;
    [SerializeField] private Transform[] spawnPoints;
    
    [SerializeField] private Transform player1;
    [SerializeField] private Camera defaultCamP1;
    [SerializeField] private Camera fpsCamP1;
    [SerializeField] private Vector3 defaultOffset;
    [SerializeField] private Vector3 fpsOffset;
    private KeyCode _switchKeyP1 = KeyCode.M;
    
    [SerializeField] private Transform player2;
    [SerializeField] private Camera defaultCamP2;
    [SerializeField] private Camera fpsCamP2;
    private KeyCode _switchKeyP2 = KeyCode.Z;
    
    void Start()
    {
        defaultCamP1.enabled = true;
        fpsCamP1.enabled = false;
        
        defaultCamP2.enabled = true;
        fpsCamP2.enabled = false;

        StartCoroutine(SpawnVehicle());
    }

    IEnumerator SpawnVehicle()
    {
        while (true)
        {
            Instantiate(offenceVehicle, spawnPoints[Random.Range(0, spawnPoints.Length)].position, spawnPoints[0].rotation);

            yield return new WaitForSeconds(3);
        }
    }

    void LateUpdate()
    {
        defaultCamP1.transform.position = player1.position + defaultOffset;
        fpsCamP1.transform.position = player1.position + fpsOffset;
        
        defaultCamP2.transform.position = player2.position + defaultOffset;
        fpsCamP2.transform.position = player2.position + fpsOffset;

        fpsCamP1.transform.rotation = player1.rotation;
        
        fpsCamP2.transform.rotation = player2.rotation;

        
        if (Input.GetKeyDown(_switchKeyP1))
        {
            defaultCamP1.enabled = !defaultCamP1.enabled;
            fpsCamP1.enabled = !fpsCamP1.enabled;
        }
        
        if (Input.GetKeyDown(_switchKeyP2))
        {
            defaultCamP2.enabled = !defaultCamP2.enabled;
            fpsCamP2.enabled = !fpsCamP2.enabled;
        }
    }
}
