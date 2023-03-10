using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("生成物件")]
    public GameObject spawnObject;
    [Header("生成的位置")]
    public Transform spawnPoint;

    public void Spawn()
    {
        // 生成(物件，座標，角度)；
        Instantiate(spawnObject, spawnPoint.position, spawnPoint.rotation);
    }
}
