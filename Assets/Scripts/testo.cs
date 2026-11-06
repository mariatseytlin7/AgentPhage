using UnityEngine; 
 
public class SmoothFollow : MonoBehaviour 
{ 
   [SerializeField]
 private GameObject target;


 public float rotationSpeed = 3f;

 private Quaternion lookRotation;

 private Vector3 directionTarget;

 private Vector3 movement;

 public int speed = 1;


public Rigidbody rb;
 
    void Update() 
    { 
      directionTarget = (target.transform.position - transform.position).normalized;
      lookRotation = Quaternion.LookRotation(directionTarget);
      transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotationSpeed);
      transform.eulerAngles = new Vector3(0, 0, 0);

      movement = transform.forward * speed;

      rb.linearVelocity = new Vector3(movement.x, movement.y, movement.z);
    } 

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == target)
        {
            Destroy(target);
            Debug.Log("touchies");
        }
    }



} 