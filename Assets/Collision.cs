using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class Collision : MonoBehaviour
    {
        public int health = 3;
        public Animator anim;
        public Text countScore;
        public Text countHealth;
        public int score;
        // Start is called before the first frame update
        void Start()
        {
            SetScore();
            SetHealth();
            print("vie = " + health);
            score = 0;
        }

        void Update()
        {
            score = score + 1;
            SetScore();
            SetHealth();
        }
        void OnCollisionEnter2D(Collision2D collision)
        {
            //(gameObject as Player).Health;
            if (collision.gameObject.tag == "Rock")
            {
                Destroy(GameObject.FindWithTag("Rock"));
                
                health -= 1;
            }
            else if (collision.gameObject.tag == "Bird")
            {
                Destroy(GameObject.FindWithTag("Bird"));

                health -= 1;
            }

            if (health == 0)
            {
                Destroy(GameObject.FindGameObjectWithTag("Spawner"));
                GameObject[] arrayR = GameObject.FindGameObjectsWithTag("Rock");
                GameObject[] arrayB = GameObject.FindGameObjectsWithTag("Bird");
                int i;
                for(i = 0; i <= arrayR.Length - 1; i++)
                {
                    Destroy(arrayR[i]);
                }
                for(i=0; i <= arrayB.Length - 1; i++)
                {
                    Destroy(arrayB[i]);
                }
                anim.SetBool("IsDead", true);
            }
        }

        void SetScore()
        {
            countScore.text = "Score :" + score.ToString();
        }

        void SetHealth()
        {
            countHealth.text = "Vie : " + health.ToString();
        }
    }
}
