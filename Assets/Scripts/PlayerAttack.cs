using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour
{

    public Rigidbody bulletPrefab;

    float attackRate = 0.25f;
    float coolDown;
    // Update is called once per frame  
    void Update()
    {
        if (Time.time >= coolDown)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                BulletAttack();
            }
        }
    }
    //按下攻击按键时创建子弹的prefab，也就是bulletPrefab。  
    void BulletAttack()
    {
        //下面的这句话非常经典，利用as Rigidbody将Instantiate的GameObject强制转换为Rigidbody类型。  
        Rigidbody bPrefab = Instantiate(bulletPrefab, transform.position, Quaternion.identity) as Rigidbody;
        bPrefab.GetComponent<Rigidbody>().AddForce(Vector3.right * 500);
        coolDown = Time.time + attackRate;
    }
}