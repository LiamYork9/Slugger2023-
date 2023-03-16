using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Scripts
{

    public class Timer : MonoBehaviour
    {

        public UnityEvent timeOut;
        [Tooltip("When AutoStart is set to true the timer will start running when the game object Loads")]
        public bool autoStart = false;
        public bool autoReStart = false;
        public float countDownTime = 1.0f;
        public float timeScale = 1.0f;
        public float timeLeft { 
            get {
                return m_timeLeft;
            } 

        }

        private float m_timeLeft = 0.0f;
        // Start is called before the first frame update
        void Start()
        {
            if (autoStart)
            StartTimer(countDownTime, autoReStart);
        }

        // Update is called once per frame
        void Update()
        {
            if(timeLeft > 0.0f)  {
                m_timeLeft -= (Time.deltaTime * timeScale);

                if (timeLeft <= 0.0f)
                {
                    timeOut.Invoke();
                    if (autoReStart)
                        StartTimer(countDownTime, autoReStart);
                }
            }
        }

        // <summary>
        /// Start timer will start the timer with the values passed in or 
        /// the public class variable if no values are passed int.
        /// </summary>
        /// <param name="_countDown"> </param>
        

        public void StartTimer(float? _countDown = null, bool _autoRestart = false)
        {
            if (_countDown != null && _countDown > 0.0f)
                countDownTime = (float)_countDown;

            autoReStart = _autoRestart;

            m_timeLeft = countDownTime;
        }
    }
}