using UnityEngine;

public class Bullet : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    int damageValue = 1;

    //用于碰撞时摧毁两个物体  
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            other.gameObject.SendMessage("EnemyDamaged", damageValue, SendMessageOptions.DontRequireReceiver);
        }
    }

    void FixedUpdate()
    {
        Destroy(gameObject, 1.25f);
    }
}
