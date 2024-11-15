using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GridManager gridManager;
    public EntityType entityType;
    public Vector2Int[] positions;
    public GameObject prefabGhost;
    // Start is called before the first frame update
    void Start()
    {
        gridManager = GetComponent<GridManager>();
        InstanciarFantasmas();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InstanciarFantasmas()
    {
        Vector2Int pos = positions[Random.Range(0,positions.Length)];
        GameObject ghost = Instantiate(prefabGhost, new Vector3(pos.x, .5f, pos.y), Quaternion.identity);
        GridEntity ghostEntity = ghost.GetComponent<GridEntity>();
        //GridPiece piece = gridManager.GetGridPiece(pos);
        //piece.OnEntityEnter(ghostEntity);
    }
}
