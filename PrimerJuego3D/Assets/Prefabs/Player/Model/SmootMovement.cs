using UnityEngine;

public class SmootMovement : IMovementStrategy
{
    
    public void Move(Transform transform, Player player )
    {

      float moveInX=Input.GetAxis("Horizontal")* player.Velocity *Time.deltaTime;
       
        transform.Translate(moveInX,0,0);
    }
    

}

