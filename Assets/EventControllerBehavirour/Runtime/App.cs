using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace com.vrglass.eventcontroller
{
    public class App : MonoBehaviour
    {
        static App instance;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else if (instance != this)
            {
                Destroy(gameObject);
            }
        }
        //Static call to Notify
        public static void Notify<T>(T notifyEvent, object[] parameters) where T : struct, IConvertible
        {
            if (instance != null)
                instance.NotifyController(notifyEvent, parameters);
        }

        private void NotifyController<T>(T notifyEvent, object[] parameters) where T : struct, IConvertible
        {
            if (notifyEvent is Enum)
            {
                if (notifyEvent.ToString().ToUpper() == "NONE")
                    return;

                var controllers = FindObjectsOfType<EventController<T>>();
                foreach (var item in controllers)
                {
                    item.NotifyController(notifyEvent, parameters);
                }
            }
            else
            {
                Debug.Log("Events should be enums: " + notifyEvent.ToString());
            }
        }

    }

}