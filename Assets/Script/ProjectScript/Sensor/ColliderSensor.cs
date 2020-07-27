using System.Collections.Generic;
using UnityEngine;

public class ColliderSensor : MonoBehaviour
{
    public AbstractRoleBehaviour colliderBeha;

    // Start is called before the first frame update
    private void Awake()
    {

    }

    void Start()
    {
        if (colliderBeha == null)
        {
            colliderBeha = this.transform.parent.parent.GetComponent<AbstractRoleBehaviour>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {

        if (colliderBeha!=null)
        {
            colliderBeha.Collider();
        }
    }
}
