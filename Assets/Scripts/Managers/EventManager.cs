using Extentions;
using UnityEngine;
using UnityEngine.Events;

namespace Managers
{
    public class EventManager : MonoSingleton<EventManager>
    {
        public UnityAction<InputParams> onInputDragged = delegate { };

        public UnityAction onObjeTemasEdince;
        //public UnityAction<int> onObjeTemasEdince;
    }
}