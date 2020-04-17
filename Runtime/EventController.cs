using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.vrglass.eventcontroller
{
    public abstract class EventController<T> : MonoBehaviour
    {
        public abstract void NotifyController(T notifyEvent, object[] parameters);
    }
}

