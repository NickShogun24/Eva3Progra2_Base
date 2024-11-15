using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridEntity_Movible_Ghost : GridEntity_Movible
{
    public GridManager gManager;
    // Start is called before the first frame update
    void Start()
    {
        gManager = GetComponent<GridManager>();
        
    }
    protected override void Awake2()
    {

    }

    // Update is called once per frame
    private void Update()
    {

    }
    protected override void Update2()
    {
        
    }

    public void SetGhostPos(Vector2Int pos)
    {
        gridPos = pos;
        gridManager.GetGridPiece(pos).OnEntityEnter(this);
    }
   
   
  
    public override void InteractWhitOtherEntity(GridEntity other)
    {
        other.InteractWhitOtherEntity(this);
    }
    protected override void Die()
    {
       
    }
    

}
