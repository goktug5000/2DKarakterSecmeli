using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharMove : MonoBehaviour
{
    public float speed,MaxHP,HP,JumpPow;
    public int MaxJump,jumpLeft;
    public Text hpMiz;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        MaxHP = 10.5f;
        HP = 10;
        JumpPow = 10;
        MaxJump=jumpLeft = 2;

        hpMiz.text = (HP-HP%1).ToString() + " /" + (MaxHP-MaxHP%1).ToString();
    }
    public void ReCreate(float Fspeed,float FMaxHP,float FHP,float FJumpPow,int FMaxJump)
    {
        speed = Fspeed;
        MaxHP = FHP;
        HP = FHP;
        JumpPow = FJumpPow;
        MaxJump = FMaxJump;
    }
    // Update is called once per frame
    void Update()
    {
//HARAKET
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.W) && jumpLeft != 0)
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * JumpPow * 20);
            jumpLeft--;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -JumpPow * 2 * Time.deltaTime, 0);
        }

//YERE İNME

    }


    void FixedUpdate()
    {
        
        // Cast a ray straight down.
        
        Vector3 v3 = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 1.55f, this.gameObject.transform.position.z);
        RaycastHit2D hit = Physics2D.Raycast(v3, -Vector2.up * 0.01f);
        Debug.DrawRay(v3, -Vector2.up * 0.01f, Color.green);
        // If it hits something...
        if (hit.distance == 0)
        {
            jumpLeft = MaxJump;
            //Debug.Log(hit.collider.gameObject.name);
        }

    }
}
