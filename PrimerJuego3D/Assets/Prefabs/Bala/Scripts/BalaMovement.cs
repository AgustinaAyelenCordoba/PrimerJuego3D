using UnityEngine;

public class BalaMovement : MonoBehaviour
{
   [SerializeField] private float velocida;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        Move();
    }
    void Move() 
    {
        transform.Translate(new Vector3(velocida*Time.deltaTime, 0, 0));
    }
}
