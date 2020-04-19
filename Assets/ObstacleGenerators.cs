using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class ObstacleGenerators : MonoBehaviour
    {
        private double delay = 3;
        private double timeCurrent = 0.0;
        public GameObject Rock;
        public GameObject Bird;
        public Vector3 position;
        public int[] selection = new int[2] { 0, 1};

        // Start is called before the first frame update
        void Start()
        {
            position = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            if (timeCurrent + delay < Time.fixedTime)
            {
                int rnd = Random.Range(0, selection.Length);
                if(selection[rnd] == 0)
                {
                    Instantiate(Rock, new Vector3(14, -3, -1), Quaternion.identity);
                }
                else if(selection[rnd] == 1)
                {
                    Instantiate(Bird, new Vector3(14, 1, -1), Quaternion.identity);
                }
                else
                {

                }
                timeCurrent = Time.fixedTime;
                delay -= 0.02;
            }
        }
    }
}