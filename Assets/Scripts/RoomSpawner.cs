using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public int openingDirection;
    public int maxRooms = 20;

    private RoomTemplates templates;
    private int random;
    private bool spawned = false;
    Transform grid;

    public static int roomsSpawned;

    void Start()
    {
        grid = GameObject.FindGameObjectWithTag("Grid").transform;
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn", 0.5f);
    }

    void Spawn()
    {
        if (!spawned && roomsSpawned < maxRooms) {
            if (openingDirection == 1) {
                random = Random.Range(0,8);
                GameObject room = Instantiate(templates.RoomsS[random], transform.position, Quaternion.identity);
                room.transform.SetParent(grid);
            } else if (openingDirection == 2) {
                random = Random.Range(0,8);
                GameObject room = Instantiate(templates.RoomsW[random], transform.position, Quaternion.identity);
                room.transform.SetParent(grid);
            } else if (openingDirection == 3) {
                random = Random.Range(0,8);
                GameObject room = Instantiate(templates.RoomsN[random], transform.position, Quaternion.identity);
                room.transform.SetParent(grid);
            } else if (openingDirection == 4) {
                random = Random.Range(0,8);
                GameObject room = Instantiate(templates.RoomsE[random], transform.position, Quaternion.identity);
                room.transform.SetParent(grid);
            }
            spawned = true;
            roomsSpawned++;
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("SpawnPoint")) {
            Destroy(gameObject);
        }
    }
}
