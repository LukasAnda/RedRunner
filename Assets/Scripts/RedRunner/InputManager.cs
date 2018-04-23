using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using RedRunner.UI;

namespace RedRunner
{

    public class InputManager : MonoBehaviour
    {

        private static InputManager m_Singleton;

        public static InputManager Singleton
        {
            get
            {
                return m_Singleton;
            }
        }

        [SerializeField]
        public UIButton jump;
        [SerializeField]
        public UIButton roll;
        [SerializeField]
        public UIButton left;
        [SerializeField]
        public UIButton right;

        private bool jumping = false;
        private bool rolling = false;
        private bool toLeft = false;
        private bool toRight = false;
       

        void Awake()
        {
            if (m_Singleton != null)
            {
                Destroy(gameObject);
                return;
            }
            m_Singleton = this;
        }

        public void doJump() {
            jumping = true;
        }

        public void stopJump() {
            jumping = false;
        }

        public void doLeft()
        {
            toLeft = true;
            toRight = false;
        }

        public void stopLeft()
        {
            toLeft = false;
        }

        public void doRight()
        {
            toRight = true;
            toLeft = false;
        }

        public void stopRight()
        {
            toRight = false;
        }

        public void doRoll()
        {
            rolling = true;
        }

        public void stopRoll()
        {
            rolling = false;
        }

        public float getHorizontalDirection() {
            if (toLeft) return -1;
            if (toRight) return 1;
            return 0;
        }

        public bool isJumpPressed() {
            return jumping;
        }

        public bool isRollPressed() {
            return rolling;
        }


    }

}