// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Valve.VR
{
    using System;
    using UnityEngine;
    
    
    public class SteamVR_Input_ActionSet_buggybuddy : Valve.VR.SteamVR_ActionSet
    {
        
        public virtual SteamVR_Action_Single Throttle
        {
            get
            {
                return SteamVR_Actions.buggybuddy_Throttle;
            }
        }
        
        public virtual SteamVR_Action_Vector2 Steer
        {
            get
            {
                return SteamVR_Actions.buggybuddy_Steer;
            }
        }
        
        public virtual SteamVR_Action_Boolean Brake
        {
            get
            {
                return SteamVR_Actions.buggybuddy_Brake;
            }
        }
        
        public virtual SteamVR_Action_Boolean Reset
        {
            get
            {
                return SteamVR_Actions.buggybuddy_Reset;
            }
        }
        
        public virtual SteamVR_Action_Boolean Turbo
        {
            get
            {
                return SteamVR_Actions.buggybuddy_Turbo;
            }
        }
    }
}