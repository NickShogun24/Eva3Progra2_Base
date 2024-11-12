using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridPiece_Floor : GridPiece
{
    public override void OnEntityExit()
    {
        
    }

    public override void OnEntityStay()
    {
        currentGridEntity.TakeDamage(1f);
    }

    
}
