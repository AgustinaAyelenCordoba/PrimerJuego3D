using UnityEngine;

public class CamaraFollwPlayer : MonoBehaviour
{
    private Vector3 offeSet;
    private PlayerMovement playerMovement;
    void Start()
    {
        offeSet = new Vector3(0,1,-5);
        playerMovement = FindObjectOfType<PlayerMovement>();
    }

   
    void LateUpdate()
    {

      gameObject.transform.position = playerMovement.transform.position +offeSet;
        
    }
}
