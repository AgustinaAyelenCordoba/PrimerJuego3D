using UnityEngine;

public class SpawBala : MonoBehaviour
{
    [SerializeField] private GameObject balas ;
    [SerializeField] private Transform spawPosicion;


  
    void Start()
    {
        InvokeRepeating("invokeBala", 5f,2f);
    }

   
    void Update()
    {
        
    }


    void invokeBala()
    {
        Instantiate(balas,spawPosicion.transform.position,spawPosicion.transform.rotation);
    }
}
