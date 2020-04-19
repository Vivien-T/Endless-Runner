using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class Player : MonoBehaviour
    {
        private bool active;
        public Animator animator;
        public BoxCollider2D boxNormale;
        public BoxCollider2D boxSlide;
        public Rigidbody2D rb;


        // Start is called before the first frame update
        void Start()
        {
            transform.position = new Vector3(-10, 0, -1);

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y <= -1.24)
            {
                animator.SetBool("IsJumping", true);
                boxNormale.enabled = true;
                boxSlide.enabled = false;
                rb.velocity = new Vector3(0, 7, 0);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                animator.SetBool("IsSliding", true);
                boxNormale.enabled = false;
                boxSlide.enabled = true;
            }
            else
            {
                animator.SetBool("IsJumping", false);
                animator.SetBool("IsSliding", false);
                boxNormale.enabled = true;
                boxSlide.enabled = false;
            }
        }
    }
}
