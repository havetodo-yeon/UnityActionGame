using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime = 3.0f;
    public Transform[] spawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        // playerHealth = GameObject.FindGameObjectsWithTag("Player").GetComponent<PlayerHealth>();
        InvokeRepeating("Spawn", spawnTime, spawnTime);
        // InvokeRepeating("�Լ�", �����̽ð�, �ݺ��ð�);
        // �ش� �Լ��� ������ �ð� ���� ȣ���ϰ�, �ݼ� �ð��� �ֱ�� �ش� �Լ��� �ݺ� ȣ���մϴ�.
    }

    void Spawn()
    {
        // �÷��̾��� ü���� 0�̶�� 
        if(playerHealth.currentHealth <= 0.0f)
        {
            return;
        }
        int sqawnPoolIndex = Random.Range(0, spawnPoints.Length);
        // ���� ������ ������ŭ ������ ��ġ�� ���� �ε����� �����ڽ��ϴ�.

        Instantiate(enemy, spawnPoints[sqawnPoolIndex].position, spawnPoints[sqawnPoolIndex].rotation);
    }

}
