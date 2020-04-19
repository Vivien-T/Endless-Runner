using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public class Rock : MonoBehaviour
    {
        private float moveSpeed = 0.05f;

        void Start()
        {

        }

        void Update()
        {
            transform.Translate(Vector2.left * moveSpeed);
        }

        public Rock()
        {
        }
    }
}
