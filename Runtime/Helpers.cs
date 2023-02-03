using System.Collections.Generic;
using UnityEngine;

namespace Yosoft.Core
{
    public static class Helpers 
    {
        private static readonly Dictionary<float, WaitForSeconds> WaitForSecondsMap = new Dictionary<float, WaitForSeconds>();

        public static WaitForSeconds GetWait(float time)
        {
            if (WaitForSecondsMap.TryGetValue(time, out var wait)) return wait;
            WaitForSecondsMap[time] = new WaitForSeconds(time);
            return WaitForSecondsMap[time];
        }
    }
}