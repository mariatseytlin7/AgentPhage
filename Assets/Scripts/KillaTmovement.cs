using UnityEngine;

public class KillaTmovement : MonoBehaviour
{
     
     private Vector3 playerPosition;

     [SerializeField]
     private GameObject player;
     
     private Vector3 playerPos; 

   

     [SerializeField]
     private float speed = 8f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPos = player.transform.position;
        //direction = (playerPos - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
        
        
        
    }

    private void MoveToPlayer()
    {
       
       transform.Translate(playerPos * Time.deltaTime * speed);

   

    }

     /*private void OnTriggerEnter(Collider other)
    {
       if (GetComponent<Collider>().gameObject.name == "Player")
        {
            Destroy(player);
        }
    }*/
}
