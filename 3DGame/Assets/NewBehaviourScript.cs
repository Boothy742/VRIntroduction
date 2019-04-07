using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform Capsule;
    public Transform Camera;

    public int AmountOfForce;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var position = Camera.position;
            position.z += 5;

            var newcapsule = Instantiate(Capsule, position, Quaternion.identity);
            var newcapsuleBody = newcapsule.GetComponent<Rigidbody>();
            newcapsuleBody.AddForce(Camera.forward * AmountOfForce, ForceMode.Force);
        }
    }
}
